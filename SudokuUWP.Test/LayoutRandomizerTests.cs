using Microsoft.VisualStudio.TestTools.UnitTesting;
using SudokuUWP.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuUWP.Test
{
    [TestClass()]
    public class LayoutRandomizerTests
    {
        // Test single row randomizer: 
        // - must have values on first row, all cells
        // - must NOT have values in any other cells
        // - first row must have all values from 1 to 9, all exactly once

        #region Helper methods used in multiple tests

        /// <summary>
        /// Check that the first row has a value other than 0 in all cells.
        /// </summary>
        /// <param name="Board"></param>
        /// <returns></returns>
        private bool FirstRowHasValuesInAllCells(GameData Board)
        {
            if (Board.Data[0, 0].Value > 0 &&
                Board.Data[1, 0].Value > 0 &&
                Board.Data[2, 0].Value > 0 &&
                Board.Data[3, 0].Value > 0 &&
                Board.Data[4, 0].Value > 0 &&
                Board.Data[5, 0].Value > 0 &&
                Board.Data[6, 0].Value > 0 &&
                Board.Data[7, 0].Value > 0 &&
                Board.Data[8, 0].Value > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Set data to first row; 1 2 3 4 5 6 7 8 9
        /// </summary>
        /// <param name="Board"></param>
        private void SetFixedDataOnFirstRow(GameData Board)
        {
            Board.Data[0, 0].Value = 1;
            Board.Data[1, 0].Value = 2;
            Board.Data[2, 0].Value = 3;
            Board.Data[3, 0].Value = 4;
            Board.Data[4, 0].Value = 5;
            Board.Data[5, 0].Value = 6;
            Board.Data[6, 0].Value = 7;
            Board.Data[7, 0].Value = 8;
            Board.Data[8, 0].Value = 9;
        }

        /// <summary>
        /// Check that all rows have values in all cells, greater than 0
        /// </summary>
        /// <param name="Board"></param>
        /// <returns></returns>
        private bool AllCellsHaveValue(GameData Board)
        {
            for (int y = 1; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    if (Board.Data[x, y].Value < 1)
                        return false;
                }
            }
            return true;
        }

        #endregion

        #region First row randomizer tests

        [TestMethod()]
        public void RandomizeFirstRow_returns_values_on_all_cells_on_first_row()
        {
            GameData Board = new GameData();
            GameLayouts Layouts = new GameLayouts();
            Layouts.RandomizeFirstRow(Board);

            bool tmpResult = FirstRowHasValuesInAllCells(Board);
            Assert.AreEqual(true, tmpResult);
        }

        [TestMethod()]
        public void RandomizeFirstRow_returns_no_values_on_cells_after_first_row()
        {
            GameData Board = new GameData();
            GameLayouts Layouts = new GameLayouts();
            Layouts.RandomizeFirstRow(Board);

            // Set value found variable to false. Will be turned to true if any values are found in any cells
            bool tmpResult = false;

            // Loop over cells; note that Y starts from 1 (= second row)
            for (int y = 1; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    if (Board.Data[x, y].Value > 0)
                        tmpResult = true;
                }
            }
            Assert.AreEqual(false, tmpResult);
        }

        [TestMethod()]
        public void RandomizeFirstRow_returns_values_one_through_nine_on_first_row()
        {
            GameData Board = new GameData();
            GameLayouts Layouts = new GameLayouts();
            Layouts.RandomizeFirstRow(Board);

            // Array to hold counts of each number:
            int[] ValueCount = new int[10];

            // Initialise counts to 0
            for (int i = 1; i < 10; i++)
            {
                ValueCount[i] = 0;
            }

            // Now go through first row and increase counts of each value found:
            for (int x = 0; x < 9; x++)
            {
                ValueCount[Board.Data[x, 0].Value]++;
            }

            // Then check that each one has a value of exactly 1
            bool tmpResult = true;
            for (int i = 1; i < 10; i++)
            {
                if (ValueCount[i] != 1)
                    tmpResult = false;
            }

            // Check result:
            Assert.AreEqual(true, tmpResult);
        }

        #endregion


        [TestMethod()]
        public void GenerateRandomNumberSequence_returns_a_list_of_9_numbers()
        {
            GameLayouts Layouts = new GameLayouts();
            List<int> RandomNumbers = Layouts.GenerateRandomNumberSequence();

            // Check that the list contains exactly 9 numbers:
            Assert.AreEqual(9, RandomNumbers.Count);
        }

        [TestMethod()]
        public void GenerateRandomNumberSequence_returns_a_list_in_which_all_numbers_exist_exactly_once()
        {
            GameLayouts Layouts = new GameLayouts();
            List<int> RandomNumbers = Layouts.GenerateRandomNumberSequence();

            // Check that each number exists exactly once:
            int[] ValueCount = new int[10];
            for (int i = 1; i < 10; i++)
            {
                ValueCount[i] = 0;
            }
            // Calculate counts:
            for (int i = 0; i < 9; i++)
            {
                ValueCount[RandomNumbers[i]]++;
            }

            // Check that each count is exactly 1:
            bool tmpResult = true;
            for (int i = 1; i < 10; i++)
            {
                if (ValueCount[i] != 1)
                    tmpResult = false;
            }

            Assert.AreEqual(true, tmpResult);
        }

        #region Row shifting tests

        [TestMethod()]
        public void CreateShiftedRow_makes_no_changes_to_data_if_any_given_value_outside_bounds()
        {
            GameData Board = new GameData();
            GameLayouts Layouts = new GameLayouts();

            // Set fixed data on first row:
            SetFixedDataOnFirstRow(Board);

            // Try shifting first row to an impossible value
            Layouts.CreateShiftedRow(Board, 1, 20, 700);

            // Make sure first row is still ok:
            Assert.AreEqual(true, FirstRowHasValuesInAllCells(Board));
        }

        [TestMethod()]
        public void CreateShiftedRow_creates_correct_target_row_using_1_as_shift_value()
        {
            GameData Board = new GameData();
            GameLayouts Layouts = new GameLayouts();

            SetFixedDataOnFirstRow(Board);

            // Shift exactly 1 step to second row
            Layouts.CreateShiftedRow(Board, 1, 2, 1);

            // Validate the second row, it should be 9 1 2 3 4 5 6 7 8
            bool tmpResult =
                (Board.Data[0, 1].Value == 9) &&
                (Board.Data[1, 1].Value == 1) &&
                (Board.Data[2, 1].Value == 2) &&
                (Board.Data[3, 1].Value == 3) &&
                (Board.Data[4, 1].Value == 4) &&
                (Board.Data[5, 1].Value == 5) &&
                (Board.Data[6, 1].Value == 6) &&
                (Board.Data[7, 1].Value == 7) &&
                (Board.Data[8, 1].Value == 8);

            Assert.AreEqual(true, tmpResult);
        }

        [TestMethod()]
        public void CreateShiftedRow_creates_correct_target_row_using_5_as_shift_value()
        {
            GameData Board = new GameData();
            GameLayouts Layouts = new GameLayouts();

            SetFixedDataOnFirstRow(Board);

            // Shift exactly 1 step to second row
            Layouts.CreateShiftedRow(Board, 1, 5, 5);

            // Validate the fifth row, it should be 5 6 7 8 9 1 2 3 4
            bool tmpResult =
                (Board.Data[0, 4].Value == 5) &&
                (Board.Data[1, 4].Value == 6) &&
                (Board.Data[2, 4].Value == 7) &&
                (Board.Data[3, 4].Value == 8) &&
                (Board.Data[4, 4].Value == 9) &&
                (Board.Data[5, 4].Value == 1) &&
                (Board.Data[6, 4].Value == 2) &&
                (Board.Data[7, 4].Value == 3) &&
                (Board.Data[8, 4].Value == 4);

            Assert.AreEqual(true, tmpResult);
        }

        #endregion


        [TestMethod()]
        public void SetSeededRandomLayout_creates_a_solvable_grid()
        {
            GameData Board = new GameData();
            GameLayouts Layouts = new GameLayouts();
            Layouts.SetSeededRandomLayout(Board);
            Assert.AreEqual(true, Board.TrySolveAll());
        }


        [TestMethod()]
        public void FillBoardWithShiftedRows_creates_expected_result_on_all_rows()
        {
            GameData Board = new GameData();
            GameLayouts Layouts = new GameLayouts();

            // Fill first row with fixed values:
            SetFixedDataOnFirstRow(Board);  // 1 2 3 4 5 6 7 8 9 

            Layouts.FillBoardWithShiftedRows(Board);

            Assert.AreEqual("123456789789123456456789123345678912912345678678912345567891234234567891891234567", Board.ToString());
        }
    }
}
