using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuUWP.Library
{
    public class GridCell
    {
        /// <summary>Current value in a cell; 0 (zero) indicates an empty cell</summary>
        public int Value = 0;

        /// <summary>Error flag denotes a cell that is in conflict</summary>
        public bool Error = false;

        /// <summary>HintCell is true when this cell has been given as a hint.</summary>
        public bool HintCell = false;

        /// <summary>Fixed cells are ones given by the game engine when setting a preset; they cannot be overwritten by user</summary>
        public bool Fixed = false;

        /// <summary>Single cells can be marked solved, when their "line" (or "square") is completely solved. This is
        /// mostly just to enable drawing said lines and / or squares with green background</summary>
        public bool Solved = false;

        /// <summary>Possible available values per cell; used when solving a board. Use positions 1 - 9 for clarity
        /// and nevermind the wasted index 0</summary>
        public bool[] PossibleValues = new bool[10];


        /// <summary>
        /// Constructor; set all possible values to true - everything is possible when a new cell is initialised.
        /// </summary>
        public GridCell()
        {
            ClearAllPossibleValues();
        }


        /// <summary>
        /// Clear all possible values of this cell.
        /// </summary>
        public void ClearAllPossibleValues()
        {
            // Set all possible values to true
            for (int i = 1; i < 10; i++)
            {
                PossibleValues[i] = true;
            }
        }

        /// <summary>
        /// Clear a cell; set the value to 0 and all flags (error, fixed, hintcell) to false
        /// </summary>
        public void Clear()
        {
            Value = 0;
            Error = false;
            HintCell = false;
            Fixed = false;
            Solved = false;
            ClearAllPossibleValues();
        }
    }
}
