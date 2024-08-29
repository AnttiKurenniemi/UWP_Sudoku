using System;
using System.Collections.Generic;
using System.Linq;


namespace SudokuUWP.Library
{
    /// <summary>
    /// This class holds the actual game data; the 9x9 array of cell values.
    /// </summary>
    public class GameData
    {
        /// <summary>
        /// Actual array of the cells on the board
        /// </summary>
        public GridCell[,] Data = new GridCell[9, 9];

        /// <summary>
        /// GridLines contains all possible "lines" through the grid; straight lines, as well as
        /// the 3x3 blocks
        /// </summary>
        private GridLinesData GridLines = new GridLinesData();

        /// <summary>
        /// Single line; this is used to check for duplicate values within a possible line
        /// </summary>
        private int[] GridLine = new int[9];

        public int LastSolvedX = -1;
        public int LastSolvedY = -1;

        /// <summary>
        /// Modified flag so that the UI can prompt to save before exit or before starting a new game.
        /// </summary>
        public bool Modified = false;

        /// <summary>
        /// Flag to indicate that the game has been solved
        /// </summary>
        public bool Solved = false;

        /// <summary>
        /// Undo list for the grid. Contains previous value for every move - grid can be unwound by
        /// setting the last value from this list and then deleting that last value.
        /// </summary>
        private List<UndoAction> UndoList = new List<UndoAction>();


        /// <summary>
        /// Initialise the cells array
        /// </summary>
        public GameData()
        {
            // Set up a grid of 9 x 9 cells
            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    Data[x, y] = new GridCell();
                }
            }
        }


        /// <summary>
        /// Return the contents of this board as a string; mainly for testing purposes.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string resultString = "";
            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    if (Data[x, y].Value < 1)
                        resultString += "0";
                    else
                        resultString += Data[x, y].Value.ToString();
                }
            }
            return resultString;
        }


        /// <summary>
        /// Generate a string of fixed values; 1 being a fixed cell, 0 not fixed
        /// </summary>
        /// <returns></returns>
        public string FixedToString()
        {
            string resultString = "";
            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    if (Data[x, y].Fixed)
                        resultString += "1";
                    else
                        resultString += "0";
                }
            }
            return resultString;
        }

        /// <summary>
        /// Clear all cells of the game grid. Reset undo stack.
        /// </summary>
        public void Clear()
        {
            Solved = false;

            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    Data[x, y].Clear();
                }
            }
            RefreshAllPossibleValues();
            UndoList.Clear();

            Modified = false;
        }


        /// <summary>
        /// Set a value to a cell, and set it to "fixed"; used when setting a preset layout.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="value"></param>
        public void SetFixedCellValue(int x, int y, int value)
        {
            Data[x, y].Value = value;
            if (value > 0)
                Data[x, y].Fixed = true;
            else
                Data[x, y].Fixed = false;
        }


        /// <summary>
        /// Set a value to a cell. Add previous value from that cell to undo stack.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="value"></param>
        public void SetCellValue(int x, int y, int value)
        {
            // Don't allow setting a new value on top of a fixed cell value:
            if (Data[x, y].Fixed)
                return;

            UndoAction undo = new UndoAction();
            undo.x = x;
            undo.y = y;
            undo.Value = Data[x, y].Value;

            UndoList.Add(undo);

            // New value:
            Data[x, y].Value = value;
            Modified = true;
        }


        /// <summary>
        /// Randomize a new game board.
        /// NOTE: This is not a good way to do it - can loop forever. Call to this method is hidden
        /// from main form...
        /// </summary>
        //public void RandomizeNew()
        //{
        //    GameLayouts Layouts = new GameLayouts();
        //    Layouts.SetSeededRandomLayout(this);

        //    RefreshAllPossibleValues();
        //}


        /// <summary>
        /// Clear a line; an array of ints that is used to validate if a given line contains
        /// specific value
        /// </summary>
        private void ClearGridLine()
        {
            for (int i = 0; i < 9; i++)
            {
                GridLine[i] = 0;
            }
        }

        /// <summary>
        /// Check for obvious conflicts on paths or squares
        /// </summary>
        /// <returns></returns>
        public bool QuickValidate()
        {
            for (int lineNumber = 0; lineNumber < GridLines.LineCount; lineNumber++)
            {
                // Clear the data against which to check:
                ClearGridLine();

                for (int elementNumber = 0; elementNumber < 9; elementNumber++)
                {
                    int x = GridLines.Lines[lineNumber, elementNumber, 0];
                    int y = GridLines.Lines[lineNumber, elementNumber, 1];

                    // Value in the given cell:
                    int cellValue = Data[x, y].Value;

                    // Catch impossible values:
                    if ((cellValue < 0) || (cellValue > 9))
                        return false;

                    // Only count values that are set (i.e. above 0)
                    if (cellValue > 0)
                    {
                        // Count how many elements are there of the current number:
                        GridLine[cellValue - 1]++;

                        // If more than one, it's a failure:
                        if (GridLine[cellValue - 1] > 1)
                            return false;
                    }
                }
            }

            return true;
        }


        /// <summary>
        /// Validate all cells and mark potentially errenuous cells
        /// </summary>
        public void ValidateAndMarkErrors()
        {
            int errorCount = 0;

            // By default all cells are ok and not solved:
            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    Data[x, y].Error = false;
                    Data[x, y].Solved = false;
                }
            }

            for (int lineNumber = 0; lineNumber < GridLines.LineCount; lineNumber++)
            {
                // Clear the data against which to check a line:
                ClearGridLine();

                for (int elementNumber = 0; elementNumber < 8; elementNumber++)
                {
                    int x = GridLines.Lines[lineNumber, elementNumber, 0];
                    int y = GridLines.Lines[lineNumber, elementNumber, 1];

                    // Value in the given cell:
                    int cellValue = Data[x, y].Value;
                    if (cellValue > 0)
                    {
                        for (int compareToElementNumber = elementNumber + 1; compareToElementNumber < 9; compareToElementNumber++)
                        {
                            int compareX = GridLines.Lines[lineNumber, compareToElementNumber, 0];
                            int compareY = GridLines.Lines[lineNumber, compareToElementNumber, 1];
                            int compareCellValue = Data[compareX, compareY].Value;

                            if (cellValue == compareCellValue)
                            {
                                // ERROR! Mark BOTH:
                                Data[x, y].Error = true;
                                Data[compareX, compareY].Error = true;
                                errorCount++;
                            }
                        }
                    }
                }
            }

            Solved = false;
            if (errorCount == 0)
            {
                // If no errors AND all cells are filled, board is finished!
                int filledCellCount = 0;
                for (int y = 0; y < 9; y++)
                {
                    for (int x = 0; x < 9; x++)
                    {
                        if (Data[x, y].Value > 0)
                            filledCellCount++;
                    }
                }

                if (filledCellCount == 81)
                    Solved = true;  // WOHOO !
                else
                    ValidateSolvedLines();
            }

            RefreshAllPossibleValues();
        }


        /// <summary>
        /// Run through all lines; if all cells within a line have a value AND no errors, then
        /// mark all cells on that line as solved. All cells have been marked "solved = false"
        /// before calling this method, so no need to worry about that.
        /// </summary>
        private void ValidateSolvedLines()
        {
            // Go through each line:
            int SolvedCellCount;
            int ErrorCellCount;
            for (int lineNumber = 0; lineNumber < GridLines.LineCount; lineNumber++)
            {
                SolvedCellCount = 0;
                ErrorCellCount = 0;

                // Go through all cells on the line:
                for (int elementNumber = 0; elementNumber < 9; elementNumber++)
                {
                    int x = GridLines.LineData(lineNumber, elementNumber).X;
                    int y = GridLines.LineData(lineNumber, elementNumber).Y;
                    if (Data[x, y].Error)
                        ErrorCellCount++;  // TODO: break -> slight optimisation...
                    else if (Data[x, y].Value > 0)
                        SolvedCellCount++;
                }

                // If all cells were solved and no errors, then the line is solved:
                if (ErrorCellCount == 0 && SolvedCellCount == 9)
                {
                    // Solved the whole line - mark it so:
                    for (int elementNumber = 0; elementNumber < 9; elementNumber++)
                    {
                        Data[GridLines.LineData(lineNumber, elementNumber).X, GridLines.LineData(lineNumber, elementNumber).Y].Solved = true;
                    }
                }
            }
        }


        /// <summary>
        /// Initially each cell has possible values of 1 through 9; this method clears that structure, setting
        /// all possible values in each cell to "true".
        /// </summary>
        private void ClearAllCellPossibleValues()
        {
            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    Data[x, y].ClearAllPossibleValues();
                }
            }
        }


        /// <summary>
        /// Re-analyse the grid, ticking off impossible values from the "possible values" array of each cell
        /// based on values in cells in crossing lines.
        /// </summary>
        public void RefreshAllPossibleValues()
        {
            // Set "possible values" of each cell to every possible value, 1..9
            ClearAllCellPossibleValues();

            // Go over each line
            for (int lineNumber = 0; lineNumber < GridLines.LineCount; lineNumber++)
            {
                // Each element on the line
                for (int elementNumber = 0; elementNumber < 9; elementNumber++)
                {
                    int x = GridLines.Lines[lineNumber, elementNumber, 0];
                    int y = GridLines.Lines[lineNumber, elementNumber, 1];

                    // Value in the given cell:
                    int cellValue = Data[x, y].Value;
                    if (cellValue > 0)
                    {
                        // This cell has a value; all of the "possible values" should be zero:
                        for (int i = 1; i < 10; i++)
                            Data[x, y].PossibleValues[i] = false;

                        // Cell has a value. Now remove that value from "PossibleValues" of all
                        // other cells on that particular line:
                        for (int OtherElementNumber = 0; OtherElementNumber < 9; OtherElementNumber++)
                        {
                            if (elementNumber != OtherElementNumber)
                            {
                                // Remove possible value
                                int otherX = GridLines.Lines[lineNumber, OtherElementNumber, 0];
                                int otherY = GridLines.Lines[lineNumber, OtherElementNumber, 1];
                                Data[otherX, otherY].PossibleValues[cellValue] = false;
                            }
                        }
                    }
                }
            }
        }


        /// <summary>
        /// Any cell can be marked as being a "hint" cell, suggested by the game engine. This method clears that flag
        /// from all cells.
        /// </summary>
        public void ClearHintValues()
        {
            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    Data[x, y].HintCell = false;
                }
            }
        }

        #region Board solving methods

        /// <summary>
        /// Check if any cell on the grid has exactly one single possible value, and value is not yet
        /// set.
        /// </summary>
        /// <param name="StopOnFirst"></param>
        /// <returns>True if value(s) found.</returns>
        private bool CheckCellsForSinglePossibleValue(bool StopOnFirst)
        {
            bool tmpResult = false;

            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    if (Data[x, y].Value < 1)
                    {
                        // This cell does not yet have a value - check if it has only one
                        // possible value:
                        int possibleValueCount = 0;
                        int possibleValue = 0;
                        for (int i = 1; i < 10; i++)
                        {
                            if (Data[x, y].PossibleValues[i])
                            {
                                possibleValueCount++;
                                possibleValue = i;
                            }
                        }
                        if (possibleValueCount == 1)
                        {
                            // Assign the value to this cell:
                            Data[x, y].PossibleValues[possibleValue] = false;
                            SetCellValue(x, y, possibleValue);

                            LastSolvedX = x;
                            LastSolvedY = y;

                            // Only one single value is possible in this cell!
                            if (StopOnFirst)
                                return true;
                            else
                                tmpResult = true;
                        }
                    }
                }
            }
            return tmpResult;
        }


        /// <summary>
        /// Check each line for "possible value" that only exists once on that line and is on a
        /// cell that does not yet have a value. If exists, it means the value must be set.
        /// </summary>
        /// <param name="StopOnFirst"></param>
        /// <returns></returns>
        private bool CheckIfPossibleValueOnLineOnce(bool StopOnFirst)
        {
            bool tmpResult = false;
            int[] PossibleValueCounts = new int[10];

            // Loop over each line:
            for (int lineNumber = 0; lineNumber < GridLines.LineCount; lineNumber++)
            {
                // Clear list of possible counts
                for (int i = 1; i < 10; i++)
                {
                    PossibleValueCounts[i] = 0;
                }

                // Each element on the line
                for (int elementNumber = 0; elementNumber < 9; elementNumber++)
                {
                    int x = GridLines.LineData(lineNumber, elementNumber).X;
                    int y = GridLines.LineData(lineNumber, elementNumber).Y;

                    // Check all possible values in this cell, if it doesn't already have a value:
                    for (int i = 1; i < 10; i++)
                    {
                        if ((Data[x, y].Value < 1) && (Data[x, y].PossibleValues[i]))
                            PossibleValueCounts[i]++;
                    }
                }

                // After going through all elements, check if any of them only has a count of 1
                for (int i = 1; i < 10; i++)
                {
                    if (PossibleValueCounts[i] == 1)
                    {
                        // YES! This value only exists ONCE on this line - now find it:
                        for (int elementNumber = 0; elementNumber < 9; elementNumber++)
                        {
                            // j is the element number on that line:
                            int x = GridLines.LineData(lineNumber, elementNumber).X;
                            int y = GridLines.LineData(lineNumber, elementNumber).Y;
                            if (Data[x, y].PossibleValues[i])
                            {
                                // Found it
                                Data[x, y].PossibleValues[i] = false;
                                SetCellValue(x, y, i);

                                LastSolvedX = x;
                                LastSolvedY = y;

                                // Only one single value is possible in this cell!
                                if (StopOnFirst)
                                    return true;
                                else
                                    tmpResult = true;
                            }
                        }
                    }
                }
            }

            return tmpResult;
        }


        /// <summary>
        /// Attempt to solve a single cell using logical deduction (no brute force)
        /// </summary>
        /// <returns></returns>
        public bool SolveSingleCell()
        {
            LastSolvedX = -1;
            LastSolvedY = -1;

            bool tmpResult = false;

            RefreshAllPossibleValues();
            if (CheckCellsForSinglePossibleValue(true))
                tmpResult = true;
            else
            {
                // Check each line; if any possible value exists on that line exacty once, it must
                // be correct value to that cell.
                if (CheckIfPossibleValueOnLineOnce(true))
                    tmpResult = true;
            }

            if (tmpResult)
            {
                // Solved one cell.
                ClearHintValues();
                RefreshAllPossibleValues();
                ValidateAndMarkErrors();

                // Mark it as a given hint
                Data[LastSolvedX, LastSolvedY].HintCell = true;
            }

            return tmpResult;
        }


        /// <summary>
        /// Keep solving single cell for as long as they can be solved, and then check if the whole board has been solved.
        /// </summary>
        /// <returns></returns>
        public bool SolveAll()
        {
            while (SolveSingleCell()) ;
            ValidateAndMarkErrors();
            return Solved;
        }


        /// <summary>
        /// Try a solution; make a copy of the current board and attemt to solve it. If it can be solved, return true (otherwise 
        /// false, duh). This is used to check if a solution is possible, without actually solving the board.
        /// </summary>
        /// <returns></returns>
        public bool TrySolveAll()
        {
            // Make a copy of the current board data:
            GameData tmpBoard = new GameData();
            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    // Do a straight up copy instead of using SetCellValue - this bypasses undo stack completely
                    // which is not needed for the tempBoard anyway
                    tmpBoard.Data[x, y].Value = Data[x, y].Value;
                }
            }

            // Attempt to solve the copy:
            return tmpBoard.SolveAll();
        }

        #endregion


        #region Undo functionality

        public int UndoStackCount()
        {
            return UndoList.Count();
        }


        /// <summary>
        /// Undo a single move.
        /// </summary>
        public bool Undo()
        {
            if (UndoList.Count() < 1)
                return false;  // No moves left to undo

            UndoAction lastAction = UndoList[UndoList.Count() - 1];

            // Set the cell value to the previous one; don't use SetCellValue as that would add
            // to the undo list again
            Data[lastAction.x, lastAction.y].Value = lastAction.Value;

            // Delete the last entry from undolist
            UndoList.Remove(lastAction);

            ValidateAndMarkErrors();
            Modified = true;

            // Return true to indicate a redraw is needed
            return true;
        }

        #endregion
    }
}
