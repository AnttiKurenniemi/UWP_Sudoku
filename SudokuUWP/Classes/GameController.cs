using System;
using System.Linq;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls;
using Windows.System;
using SudokuUWP.Library;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SudokuUWP.Classes
{
    /// <summary>
    /// This is the actual controller of the game, that the UI code calls.
    /// </summary>
    public class GameController
    {
        private ObservableCollection<Cell> _cells = new ObservableCollection<Cell>
            {
                new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(),
                new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(),
                new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(),

                new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(),
                new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(),
                new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(),

                new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(),
                new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(),
                new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell()
            };

        private int SelectedCellIndex = -1;
        private int LastUsedValue = 0;
        public bool Solved = false;

        /// <summary>
        /// Identifier of the selected game layout; this is only ever used in debug mode, to make it possible to 
        /// estimate the difficulty level of each game
        /// </summary>
        public int currentLayoutIndex = -1;

        public GameDifficulty currentLayoutDifficulty = GameDifficulty.Unknown;


        /// <summary>
        /// List of game moves, for Undo functionality
        /// </summary>
        private List<UndoItem> UndoList = new List<UndoItem>();

        /// <summary>
        /// This array holds the number of solved cells per each number (0 - 9)
        /// </summary>
        private int[] SolvedCounts = new int[10];


        /// <summary>
        /// The UI code calls this method to get the collection of cells, to use for binding to the grid
        /// </summary>
        /// <returns></returns>
        public ObservableCollection<Cell> GetCells()
        {
            return _cells;
        }


        /// <summary>
        /// Assign the given cell "Selected" value. If another cell is previously selected, that one will be
        /// un-selected first.
        /// </summary>
        /// <param name="border"></param>
        public void SetSelectedCell(Border border)
        {
            if (Solved)
                SetSelectedCellIndex(-1);
            else
            {
                var newIndex = Int32.Parse(border.Tag.ToString());  // Cell identifier in Cells collection
                SetSelectedCellIndex(newIndex);
                if (_cells[newIndex].Value != null)
                    LastUsedValue = (int)_cells[newIndex].Value;
                SetSameNumberHighlight();
            }
        }

        /// <summary>
        /// As a double-click event result, set a value to a cell if it is empty, to whatever value was last used.
        /// </summary>
        /// <param name="border"></param>
        public void AssignLastUsedValueToCell(Border border)
        {
            var newIndex = Int32.Parse(border.Tag.ToString());
            if (LastUsedValue > 0 && _cells[newIndex].Value == null)
            {
                AssignCurrentCellValue(LastUsedValue);
                ValidateGame();
            }
        }


        /// <summary>
        /// Set a cell as selected; remove previous selection if one was selected
        /// </summary>
        /// <param name="newIndex"></param>
        private void SetSelectedCellIndex(int newIndex)
        {
            if (SelectedCellIndex > -1)
                _cells[SelectedCellIndex].Selected = false;

            SelectedCellIndex = newIndex;  // Cell identifier in Cells collection
            if (SelectedCellIndex > -1)
                _cells[SelectedCellIndex].Selected = true;
        }


        /// <summary>
        /// If a cell is selected, un-select it so that nothing is selected
        /// </summary>
        private void RemoveSelection()
        {
            if (SelectedCellIndex > -1)
            {
                _cells[SelectedCellIndex].Selected = false;
                SelectedCellIndex = -1;
            }
        }

        /// <summary>
        /// A key has been pressed in the UI; assign the number value to the currently selected cell (if any)
        /// </summary>
        /// <param name="args"></param>
        public void AssignCellValue(Windows.UI.Core.KeyEventArgs args)
        {
            if (SelectedCellIndex < 0)
                return;

            if ((args.VirtualKey == VirtualKey.Number0) || (args.VirtualKey == VirtualKey.NumberPad0) || (args.VirtualKey == VirtualKey.Delete) || (args.VirtualKey == VirtualKey.Back))
                AssignCurrentCellValue(0);
            else if ((args.VirtualKey == VirtualKey.Number1) || (args.VirtualKey == VirtualKey.NumberPad1))
                AssignCurrentCellValue(1);
            else if ((args.VirtualKey == VirtualKey.Number2) || (args.VirtualKey == VirtualKey.NumberPad2))
                AssignCurrentCellValue(2);
            else if ((args.VirtualKey == VirtualKey.Number3) || (args.VirtualKey == VirtualKey.NumberPad3))
                AssignCurrentCellValue(3);
            else if ((args.VirtualKey == VirtualKey.Number4) || (args.VirtualKey == VirtualKey.NumberPad4))
                AssignCurrentCellValue(4);
            else if ((args.VirtualKey == VirtualKey.Number5) || (args.VirtualKey == VirtualKey.NumberPad5))
                AssignCurrentCellValue(5);
            else if ((args.VirtualKey == VirtualKey.Number6) || (args.VirtualKey == VirtualKey.NumberPad6))
                AssignCurrentCellValue(6);
            else if ((args.VirtualKey == VirtualKey.Number7) || (args.VirtualKey == VirtualKey.NumberPad7))
                AssignCurrentCellValue(7);
            else if ((args.VirtualKey == VirtualKey.Number8) || (args.VirtualKey == VirtualKey.NumberPad8))
                AssignCurrentCellValue(8);
            else if ((args.VirtualKey == VirtualKey.Number9) || (args.VirtualKey == VirtualKey.NumberPad9))
                AssignCurrentCellValue(9);

            else if (args.VirtualKey == VirtualKey.Left)
            {
                // Move left: index -1
                var newIndex = SelectedCellIndex - 1;
                if ((newIndex + 1) % 9 == 0 || newIndex < 0)  // Just past left edge
                    newIndex += 9;
                SetSelectedCellIndex(newIndex);
            }
            else if (args.VirtualKey == VirtualKey.Right)
            {
                // Move Right
                var newIndex = SelectedCellIndex + 1;
                if (newIndex % 9 == 0)  // Just past right edge
                    newIndex -= 9;
                SetSelectedCellIndex(newIndex);
            }
            else if (args.VirtualKey == VirtualKey.Up)
            {
                // Move Up
                var newIndex = SelectedCellIndex - 9;
                if (newIndex < 0)
                    newIndex += 81;
                SetSelectedCellIndex(newIndex);
            }
            else if (args.VirtualKey == VirtualKey.Down)
            {
                // Move Down
                var newIndex = SelectedCellIndex + 9;
                if (newIndex > 80)
                    newIndex -= 81;
                SetSelectedCellIndex(newIndex);
            }
        }

        /// <summary>
        /// Assign an actual value to the currently selected cell.
        /// </summary>
        /// <param name="value"></param>
        private void AssignCurrentCellValue(int value)
        {
            if (SelectedCellIndex > -1)
            {
                if (value != _cells[SelectedCellIndex].Value && _cells[SelectedCellIndex].Given != true)
                {
                    // Store previous value to undo list:
                    UndoList.Add(new UndoItem { cellIndex = SelectedCellIndex, previousValue = _cells[SelectedCellIndex].Value });

                    // Set new value to cell:
                    _cells[SelectedCellIndex].Value = value;
                    if (value < 1)
                        _cells[SelectedCellIndex].Solved = false;

                    // Clean up any hint cell, EXCEPT if it is this particular one:
                    RemovePreviousHintCells();
                }
            }

            if (value > 0)
                LastUsedValue = value;
        }




        /// <summary>
        /// Clear the whole grid.
        /// </summary>
        public void Clear()
        {
            foreach (var cell in _cells)
            {
                cell.Clear();
            }
            RemoveSelection();
            UndoList.Clear();
            Solved = false;
        }


        /// <summary>
        /// Randomize a preset value to all cells
        /// </summary>
        public void SetRandomPreset()
        {
            Clear();
            GameLayouts layouts = new GameLayouts();
            GameData Board = new GameData();
            currentLayoutIndex = layouts.SetRandomLayout(Board);
            currentLayoutDifficulty = layouts.Layouts[currentLayoutIndex].Difficulty;

            // Copy from Board to Cells
            BoardToInitialCells(Board);
            UndoList.Clear();
        }


        /// <summary>
        /// Randomize a preset value to all cells
        /// </summary>
        public void SetRandomUnknownPreset()
        {
            Clear();
            GameLayouts layouts = new GameLayouts();
            GameData Board = new GameData();
            do
            {
                currentLayoutIndex = layouts.SetRandomLayout(Board);
                currentLayoutDifficulty = layouts.Layouts[currentLayoutIndex].Difficulty;
            }
            while (currentLayoutDifficulty != GameDifficulty.Unknown);

            // Copy from Board to Cells
            BoardToInitialCells(Board);
            UndoList.Clear();
        }


        /// <summary>
        /// Return the number of layouts where difficulty is Unknown; used for testing / debugging.
        /// </summary>
        /// <returns></returns>
        public int UnknownDifficultCount()
        {
            GameLayouts layouts = new GameLayouts();
            return layouts.Layouts.Count(x => x.Difficulty == GameDifficulty.Unknown);
        }


        /// <summary>
        /// Get a GameData board and all values from it, to _cells, marking each number as "given"
        /// </summary>
        /// <param name="Board"></param>
        private void BoardToInitialCells(GameData Board)
        {
            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    int cellIndex = (y * 9) + x;
                    if (Board.Data[x, y].Value > 0)
                    {
                        _cells[cellIndex].Value = Board.Data[x, y].Value;
                        _cells[cellIndex].Given = true;
                    }
                }
            }
        }




        /// <summary>
        /// Get all cell values from the "Board"; don't change actual values
        /// </summary>
        /// <param name="Board"></param>
        private void BoardToCellStates(GameData Board)
        {
            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    int cellIndex = (y * 9) + x;
                    if (Board.Data[x, y].Value > 0)
                    {
                        if (Board.Data[x, y].Error)
                            _cells[cellIndex].State = CellState.Error;
                        _cells[cellIndex].Solved = (Board.Data[x, y].Solved && _cells[cellIndex].Value != null);
                    }
                }
            }
        }


        /// <summary>
        /// Set state of any "hint" cells to normal cells.
        /// </summary>
        private void RemovePreviousHintCells()
        {
            foreach (var cell in _cells)
            {
                if (cell.State == CellState.Hint)
                    cell.State = CellState.Normal;
            }
        }


        /// <summary>
        /// Get values from GameData object (board) to the _cells collection
        /// </summary>
        /// <param name="Board"></param>
        private void BoardToCells(GameData Board)
        {
            RemovePreviousHintCells();

            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    int cellIndex = (y * 9) + x;
                    if (Board.Data[x, y].Value > 0)
                    {
                        _cells[cellIndex].Value = Board.Data[x, y].Value;
                        if (Board.Data[x, y].HintCell)
                            _cells[cellIndex].State = CellState.Hint;
                        if (Board.Solved)
                        {
                            _cells[cellIndex].Solved = true;
                            _cells[cellIndex].DigitSolved = true;
                        }
                    }
                }
            }
        }


        /// <summary>
        /// Create a GameData board of values, from the _cells collection
        /// </summary>
        /// <param name="Board"></param>
        private void CellsToBoard(GameData Board)
        {
            int newValue;
            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    int cellIndex = (y * 9) + x;

                    if (_cells[cellIndex].Value != null)
                        newValue = (int)_cells[cellIndex].Value;
                    else
                        newValue = 0;

                    Board.Data[x, y].Value = newValue;
                }
            }
        }


        /// <summary>
        /// Remove any Error states from cells
        /// </summary>
        private void ClearAllErrors()
        {
            foreach (Cell cell in _cells)
            {
                if (cell.State == CellState.Error)
                    cell.State = CellState.Normal;
                if (cell.Solved && cell.Value == null)
                    cell.Solved = false;
                if (cell.DigitSolved && cell.Value == null)
                    cell.DigitSolved = false;
            }
        }


        /// <summary>
        /// Highlight all cells with the same number as currently selected value
        /// </summary>
        private void SetSameNumberHighlight()
        {
            int sameValue = -2;
            if (SelectedCellIndex > -1 && _cells[SelectedCellIndex].Value > 0)
                sameValue = (int)_cells[SelectedCellIndex].Value;

            foreach (var cell in _cells)
            {
                cell.SameValue = (cell.Value == sameValue);
            }
        }


        /// <summary>
        /// After each validation cycle, check if any numbers have been fully solved.
        /// </summary>
        public void HighlightFullySolvedDigits()
        {
            // Start from 0 solved of each number:
            for (int i = 1; i < 10; i++)
                SolvedCounts[i] = 0;

            // Go through board and increase each count:
            foreach (var cell in _cells)
            {
                if (cell.Value > 0)
                    SolvedCounts[(int)cell.Value]++;
            }

            // Then for any values that are completely solved, set the flag:
            foreach (var cell in _cells)
            {
                if (cell.Value > 0 && SolvedCounts[(int)cell.Value] > 8)
                    cell.DigitSolved = true;
                else
                    cell.DigitSolved = false;
            }
        }


        /// <summary>
        /// Check the game for completion and/or errors
        /// </summary>
        public void ValidateGame()
        {
            var Board = new GameData();
            CellsToBoard(Board);
            Board.ValidateAndMarkErrors();

            ClearAllErrors();

            if (Board.Solved)
            {
                if (SelectedCellIndex > -1)
                {
                    _cells[SelectedCellIndex].Solved = true;
                    RemoveSelection();
                }
                Solved = true;
            }
            else
            {
                BoardToCellStates(Board);
                SetSameNumberHighlight();
            }
            HighlightFullySolvedDigits();
        }


        /// <summary>
        /// Check if any of the cells have a value; if not, then the board is empty
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            for (int i = 0; i < _cells.Count; i++)
            {
                if (_cells[i].Value != null && _cells[i].Value > 0)
                    return false;
            }
            return true;
        }


        /// <summary>
        /// Solve the game (if possible)
        /// </summary>
        public void SolveGame()
        {
            var Board = new GameData();
            CellsToBoard(Board);
            Board.SolveAll();

            if (Board.Solved)
            {
                // Solving was ok, get values to the current grid:
                ClearAllErrors();
                RemoveSelection();
                BoardToCells(Board);
                Solved = true;
            }
        }


        /// <summary>
        /// Attempt to solve the game; this is used after each move to see if the game can still be solved
        /// or not
        /// </summary>
        /// <returns></returns>
        public async Task<bool> TrySolveAsync()
        {
            var Board = new GameData();
            CellsToBoard(Board);

            var tmpResult = await Task.FromResult<bool>(Board.TrySolveAll());
               
            return tmpResult;
        }


        /// <summary>
        /// Try to solve a single cell; if it is possible, mark that cell as hint cell, to display it 
        /// differently.
        /// </summary>
        /// <returns></returns>
        public bool SolveSingleHintCell()
        {
            var Board = new GameData();
            CellsToBoard(Board);
            if (Board.SolveSingleCell())
            {
                // Managed to solve a single cell. First make an undo entry
                int solvedCellIndex = (Board.LastSolvedY * 9) + Board.LastSolvedX;
                UndoList.Add(new UndoItem { cellIndex = solvedCellIndex, previousValue = null });  // null because only empty cells could have been solved

                // Show the solved cell:
                BoardToCells(Board);
                ValidateGame();
                return true;
            }
            else
                return false;
        }


        /// <summary>
        /// Undo last move by setting the last assigned cell value to what it was before that. Remove the
        /// last entry from the undo list
        /// </summary>
        public void UndoMove()
        {
            if (UndoList.Count > 0)
            {
                _cells[UndoList[UndoList.Count - 1].cellIndex].Value = UndoList[UndoList.Count - 1].previousValue;
                UndoList.RemoveAt(UndoList.Count - 1);
                ValidateGame();
            }
        }
    }
}
