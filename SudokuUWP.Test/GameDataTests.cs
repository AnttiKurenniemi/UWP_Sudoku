using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SudokuUWP.Library;

namespace SudokuUWP.Test
{
    [TestClass]
    public class GameDataTests
    {
        /// <summary>
        /// When initialising a new GameData, all cell values should be zero.
        /// </summary>
        [TestMethod()]
        public void New_GameData_all_cells_value_zero()
        {
            GameData Grid = new GameData();
            bool AllOk = true;
            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    if (Grid.Data[x, y].Value != 0)
                        AllOk = false;
                }
            }
            Assert.AreEqual(true, AllOk);
        }

        [TestMethod()]
        public void New_GameData_all_cells_error_status_false()
        {
            GameData Grid = new GameData();
            bool AllOk = true;
            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    if (Grid.Data[x, y].Error != false)
                        AllOk = false;
                }
            }
            Assert.AreEqual(true, AllOk);
        }



        [TestMethod()]
        public void GameData_after_Clear_all_cells_value_zero()
        {
            GameData Grid = new GameData();

            // Set some values:
            Grid.Data[2, 3].Value = 5;
            Grid.Data[1, 4].Value = 3;
            Grid.Data[5, 2].Value = 8;
            Grid.Data[7, 0].Value = 4;

            // Clear:
            Grid.Clear();

            bool AllOk = true;
            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    if (Grid.Data[x, y].Value != 0)
                        AllOk = false;
                }
            }
            Assert.AreEqual(true, AllOk);
        }

        [TestMethod()]
        public void GameData_after_Clear_all_cells_error_status_false()
        {
            GameData Grid = new GameData();

            // Set some errors:
            Grid.Data[2, 3].Error = true;
            Grid.Data[1, 4].Error = true;
            Grid.Data[5, 2].Error = true;
            Grid.Data[7, 0].Error = true;

            // Clear:
            Grid.Clear();

            bool AllOk = true;
            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    if (Grid.Data[x, y].Error != false)
                        AllOk = false;
                }
            }
            Assert.AreEqual(true, AllOk);
        }


        [TestMethod()]
        public void GameData_after_Clear_all_cells_fixed_status_false()
        {
            GameData Grid = new GameData();

            // Set some errors:
            Grid.Data[2, 3].Error = true;
            Grid.Data[1, 4].Error = true;
            Grid.Data[5, 2].Error = true;
            Grid.Data[7, 0].Error = true;

            // Clear:
            Grid.Clear();

            bool AllOk = true;
            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    if (Grid.Data[x, y].Fixed != false)
                        AllOk = false;
                }
            }
            Assert.AreEqual(true, AllOk);
        }



        #region Undo list functionality

        /// <summary>
        /// A new grid should have undo stack length zero
        /// </summary>
        [TestMethod()]
        public void New_grid_undo_stack_is_empty()
        {
            GameData Grid = new GameData();
            Assert.AreEqual(0, Grid.UndoStackCount());
        }

        [TestMethod()]
        public void Setting_cell_value_increases_undo_stack_count_by_one()
        {
            GameData Grid = new GameData();
            Grid.SetCellValue(1, 1, 5);
            Assert.AreEqual(1, Grid.UndoStackCount());
        }

        [TestMethod()]
        public void Setting_fixed_cell_value_does_not_increase_undo_stack_count()
        {
            GameData Grid = new GameData();
            Grid.SetFixedCellValue(1, 1, 5);
            Assert.AreEqual(0, Grid.UndoStackCount());
        }

        [TestMethod()]
        public void Setting_cell_values_and_then_clearing_cell_undo_stack_should_be_empty()
        {
            GameData Grid = new GameData();
            Grid.SetCellValue(1, 1, 5);
            Assert.AreEqual(1, Grid.UndoStackCount());

            Grid.Clear();
            Assert.AreEqual(0, Grid.UndoStackCount());
        }

        [TestMethod()]
        public void Calling_undo_on_empty_undo_stack_does_not_throw_exception()
        {
            GameData Grid = new GameData();
            Assert.AreEqual(0, Grid.UndoStackCount());
            bool exceptionRaised = false;
            try
            {
                Grid.Undo();
            }
            catch
            {
                exceptionRaised = true;
            }
            Assert.AreEqual(false, exceptionRaised);
        }

        [TestMethod()]
        public void Calling_undo_decreases_undo_stack_count_by_one()
        {
            GameData Grid = new GameData();
            Assert.AreEqual(0, Grid.UndoStackCount());

            Grid.SetCellValue(1, 1, 5);
            Assert.AreEqual(1, Grid.UndoStackCount());

            Grid.Undo();
            Assert.AreEqual(0, Grid.UndoStackCount());
        }

        [TestMethod()]
        public void Calling_undo_clears_the_correct_cell_value()
        {
            GameData Grid = new GameData();
            Grid.SetCellValue(1, 2, 5);
            Assert.AreEqual(5, Grid.Data[1, 2].Value);
            Grid.Undo();
            Assert.AreEqual(0, Grid.Data[1, 2].Value);
        }

        #endregion


        #region Modified flag related functionality

        [TestMethod()]
        public void New_game_modified_is_false()
        {
            GameData SUT = new GameData();
            Assert.IsFalse(SUT.Modified);
        }

        [TestMethod()]
        public void After_calling_SetCellValue_modified_is_true()
        {
            GameData SUT = new GameData();
            SUT.SetCellValue(1, 1, 1);
            Assert.IsTrue(SUT.Modified);
        }

        [TestMethod()]
        public void After_setting_values_and_clearing_modified_is_again_false()
        {
            GameData SUT = new GameData();
            Assert.IsFalse(SUT.Modified);

            SUT.SetCellValue(1, 1, 1);
            Assert.IsTrue(SUT.Modified);

            SUT.Clear();
            Assert.IsFalse(SUT.Modified);
        }

        [TestMethod()]
        public void Calling_Undo_sets_modified_flag_to_true()
        {
            GameData SUT = new GameData();
            Assert.IsFalse(SUT.Modified);

            SUT.SetCellValue(1, 1, 1);
            Assert.IsTrue(SUT.Modified);

            // Force the Modified flag to false:
            SUT.Modified = false;

            // Double-dummy-check
            Assert.IsFalse(SUT.Modified);

            // Call Undo -> should flag game as modified
            SUT.Undo();
            Assert.IsTrue(SUT.Modified);
        }

        #endregion
    }
}