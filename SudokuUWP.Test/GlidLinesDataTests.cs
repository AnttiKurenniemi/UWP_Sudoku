using Microsoft.VisualStudio.TestTools.UnitTesting;
using SudokuUWP.Library;


namespace SudokuUWP.Test
{
    [TestClass()]
    public class GridLinesDataTests
    {
        [TestMethod()]
        public void LineData_X_returns_same_as_array_content()
        {
            GridLinesData lineData = new GridLinesData();
            int x1 = lineData.Lines[5, 5, 0];
            int x2 = lineData.LineData(5, 5).X;
            Assert.AreEqual(x1, x2);
        }

        [TestMethod()]
        public void LineData_Y_returns_same_as_array_content()
        {
            GridLinesData lineData = new GridLinesData();
            int y1 = lineData.Lines[7, 7, 0];
            int y2 = lineData.LineData(7, 7).Y;
            Assert.AreEqual(y1, y2);
        }
    }
}
