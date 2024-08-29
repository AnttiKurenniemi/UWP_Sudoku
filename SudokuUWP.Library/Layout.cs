using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuUWP.Library
{
    public enum GameDifficulty { Unknown, Easy, Medium, Hard }


    /// <summary>
    /// Represents a single initial layout
    /// </summary>
    public class Layout
    {
        public string Data { get; set; }
        public GameDifficulty Difficulty { get; set; }
        public string OriginalSource { get; set; }
    }
}
