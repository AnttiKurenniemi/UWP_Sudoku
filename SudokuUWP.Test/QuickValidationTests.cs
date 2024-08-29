using Microsoft.VisualStudio.TestTools.UnitTesting;
using SudokuUWP.Library;


namespace SudokuUWP.Test
{
    [TestClass()]
    public class QuickValidationTests
    {
        private GameData SetupEmptyBoard()
        {
            GameData tmp = new GameData();
            return tmp;
        }

        [TestMethod()]
        public void QuickValidate_returns_true_for_empty_grid()
        {
            GameData testData = SetupEmptyBoard();
            Assert.AreEqual(true, testData.QuickValidate());
        }

        [TestMethod()]
        public void QuickValidate_returns_false_when_value_greater_than_9_found()
        {
            GameData testData = SetupEmptyBoard();
            testData.Data[4, 4].Value = 12;
            Assert.AreEqual(false, testData.QuickValidate());
        }

        [TestMethod()]
        public void QuickValidate_returns_false_when_value_less_than_0_found()
        {
            GameData testData = SetupEmptyBoard();
            testData.Data[5, 6].Value = -5;
            Assert.AreEqual(false, testData.QuickValidate());
        }

        [TestMethod()]
        public void QuickValidate_returns_true_for_valid_row_1()
        {
            GameData testData = SetupEmptyBoard();
            testData.Data[0, 0].Value = 1;
            testData.Data[1, 0].Value = 2;
            testData.Data[2, 0].Value = 3;
            testData.Data[3, 0].Value = 4;
            testData.Data[4, 0].Value = 5;
            testData.Data[5, 0].Value = 6;
            testData.Data[6, 0].Value = 7;
            testData.Data[7, 0].Value = 8;
            testData.Data[8, 0].Value = 9;
            Assert.AreEqual(true, testData.QuickValidate());
        }

        [TestMethod()]
        public void QuickValidate_returns_false_for_invalid_row_1()
        {
            GameData testData = SetupEmptyBoard();
            testData.Data[0, 0].Value = 1;
            testData.Data[1, 0].Value = 2;
            testData.Data[2, 0].Value = 3;
            testData.Data[3, 0].Value = 4;
            testData.Data[4, 0].Value = 5;
            testData.Data[5, 0].Value = 5;  // Here be error
            testData.Data[6, 0].Value = 7;
            testData.Data[7, 0].Value = 8;
            testData.Data[8, 0].Value = 9;
            Assert.AreEqual(false, testData.QuickValidate());
        }

        [TestMethod()]
        public void QuickValidate_returns_true_for_valid_column_4()
        {
            GameData testData = SetupEmptyBoard();
            testData.Data[4, 0].Value = 1;
            testData.Data[4, 1].Value = 2;
            testData.Data[4, 2].Value = 3;
            testData.Data[4, 3].Value = 4;
            testData.Data[4, 4].Value = 5;
            testData.Data[4, 5].Value = 6;
            testData.Data[4, 6].Value = 7;
            testData.Data[4, 7].Value = 8;
            testData.Data[4, 8].Value = 9;
            Assert.AreEqual(true, testData.QuickValidate());
        }

        [TestMethod()]
        public void QuickValidate_returns_false_for_invalid_column_5()
        {
            GameData testData = SetupEmptyBoard();
            testData.Data[5, 0].Value = 1;
            testData.Data[5, 1].Value = 2;
            testData.Data[5, 2].Value = 3;
            testData.Data[5, 3].Value = 4;
            testData.Data[5, 4].Value = 5;
            testData.Data[5, 5].Value = 6;
            testData.Data[5, 6].Value = 3;  // Error here
            testData.Data[5, 7].Value = 8;
            testData.Data[5, 8].Value = 9;
            Assert.AreEqual(false, testData.QuickValidate());
        }


        [TestMethod()]
        public void QuickValidate_returns_true_for_valid_block_top_center()
        {
            GameData testData = SetupEmptyBoard();
            testData.Data[3, 0].Value = 1;
            testData.Data[4, 0].Value = 2;
            testData.Data[4, 0].Value = 3;
            testData.Data[3, 1].Value = 4;
            testData.Data[4, 1].Value = 5;
            testData.Data[5, 1].Value = 6;
            testData.Data[3, 2].Value = 7;
            testData.Data[4, 2].Value = 8;
            testData.Data[5, 2].Value = 9;
            Assert.AreEqual(true, testData.QuickValidate());
        }

        [TestMethod()]
        public void QuickValidate_returns_false_for_invalid_block_bottom_right()
        {
            GameData testData = SetupEmptyBoard();
            testData.Data[6, 6].Value = 1;
            testData.Data[7, 6].Value = 2;
            testData.Data[8, 6].Value = 3;
            testData.Data[6, 7].Value = 4;
            testData.Data[7, 7].Value = 5;
            testData.Data[8, 7].Value = 6;
            testData.Data[6, 8].Value = 3;  // Error here
            testData.Data[7, 8].Value = 8;
            testData.Data[8, 8].Value = 9;
            Assert.AreEqual(false, testData.QuickValidate());
        }
    }
}
