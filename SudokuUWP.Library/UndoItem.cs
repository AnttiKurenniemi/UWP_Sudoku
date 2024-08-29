using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuUWP.Library
{
    public class UndoItem
    {
        public int cellIndex = -1;
        public int? previousValue = null;
    }
}
