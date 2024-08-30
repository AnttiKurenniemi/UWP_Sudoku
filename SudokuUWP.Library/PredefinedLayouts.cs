using System;
using System.Collections.Generic;

namespace SudokuUWP.Library
{
    /// <summary>
    /// This class produces a number of pre-set layouts to begin a game with.
    /// </summary>
    public class GameLayouts
    {
        /// <summary>Randomizer is used to randomize layouts, rotate and shuffle numbers</summary>
        private readonly Random Randomizer = new Random();


        /// <summary>All predefined layouts. More variations can be created from these by rotating, 
        /// flipping horizontally or vertically and shuffling numbers around.</summary>
        public List<Layout> Layouts = new List<Layout>()
        {
            new Layout { Data = "030020000200009763004107080007008600020705010001300200050901400642500007000040030", Difficulty = GameDifficulty.Easy, OriginalSource = "" },   // 0
            new Layout { Data = "900050610200400007350006400004005000000109000000300100005600078600001003093070001", Difficulty = GameDifficulty.Medium, OriginalSource = "" },
            new Layout { Data = "000000075003000809400083000780006010000570000000000002030100008005000000019000060", Difficulty = GameDifficulty.Hard, OriginalSource = "https://www.puzzles.ca/sudoku_puzzles/sudoku_hard_381.html" },
            new Layout { Data = "216700800700000000400002076594030610000265000023040758980100005000000007007004283", Difficulty = GameDifficulty.Easy, OriginalSource = "" },
            new Layout { Data = "000260701680070090190004500820100040004602900050003028009300074040050036703018000", Difficulty = GameDifficulty.Easy, OriginalSource = "" },
            new Layout { Data = "100489006730000040000001295007120600500703008006095700914600000020000037800512004", Difficulty = GameDifficulty.Easy, OriginalSource = "" },
            new Layout { Data = "003020600900305001001806400008102900700000008006708200002609500800203009005010300", Difficulty = GameDifficulty.Medium, OriginalSource = "" },
            new Layout { Data = "200080300060070084030500209000105408000000000402706000301007040720040060004010003", Difficulty = GameDifficulty.Medium, OriginalSource = "" },
            new Layout { Data = "000000907000420180000705026100904000050000040000507009920108000034059000507000000", Difficulty = GameDifficulty.Easy, OriginalSource = "" },
            new Layout { Data = "030050040008010500460000012070502080000603000040109030250000098001020600080060020", Difficulty = GameDifficulty.Hard, OriginalSource = "" },

            new Layout { Data = "020810740700003100090002805009040087400208003160030200302700060005600008076051090", Difficulty = GameDifficulty.Easy, OriginalSource = "" },  // 10
            new Layout { Data = "480006902002008001900370060840010200003704100001060049020085007700900600609200018", Difficulty = GameDifficulty.Easy, OriginalSource = "" },
            new Layout { Data = "000900002050123400030000160908000000070000090000000205091000050007439020400007000", Difficulty = GameDifficulty.Hard, OriginalSource = "" },
            new Layout { Data = "000125400008400000420800000030000095060902010510000060000003049000007200001298000", Difficulty = GameDifficulty.Easy, OriginalSource = "" },
            new Layout { Data = "062340750100005600570000040000094800400000006005830000030000091006400007059083260", Difficulty = GameDifficulty.Easy, OriginalSource = "" },
            new Layout { Data = "300000000005009000200504000020000700160000058704310600000890100000067080000005437", Difficulty = GameDifficulty.Medium, OriginalSource = "" },
            new Layout { Data = "630000000000500008005674000000020000003401020000000345000007004080300902947100080", Difficulty = GameDifficulty.Medium, OriginalSource = "" },
            new Layout { Data = "000020040008035000000070602031046970200000000000501203049000730000000010800004000", Difficulty = GameDifficulty.Medium, OriginalSource = "" },
            new Layout { Data = "361025900080960010400000057008000471000603000259000800740000005020018060005470329", Difficulty = GameDifficulty.Easy, OriginalSource = "" },
            new Layout { Data = "050807020600010090702540006070020301504000908103080070900076205060090003080103040", Difficulty = GameDifficulty.Easy, OriginalSource = "" },

            new Layout { Data = "080005000000003457000070809060400903007010500408007020901020000842300000000100080", Difficulty = GameDifficulty.Medium, OriginalSource = "" },  // 20
            new Layout { Data = "003502900000040000106000305900251008070408030800763001308000104000020000005104800", Difficulty = GameDifficulty.Easy, OriginalSource = "" },
            new Layout { Data = "000000000009805100051907420290401065000000000140508093026709580005103600000000000", Difficulty = GameDifficulty.Easy, OriginalSource = "" },
            new Layout { Data = "020030090000907000900208005004806500607000208003102900800605007000309000030020050", Difficulty = GameDifficulty.Hard, OriginalSource = "" },  // 23 : Hard
            new Layout { Data = "005000006070009020000500107804150000000803000000092805907006000030400010200000600", Difficulty = GameDifficulty.Medium, OriginalSource = "" },
            new Layout { Data = "040000050001943600009000300600050002103000506800020007005000200002436700030000040", Difficulty = GameDifficulty.Easy, OriginalSource = "" },
            new Layout { Data = "004000000000030002390700080400009001209801307600200008010008053900040000000000800", Difficulty = GameDifficulty.Medium, OriginalSource = "" },
            new Layout { Data = "500400060009000800640020000000001008208000501700500000000090084003000600060003002", Difficulty = GameDifficulty.Medium, OriginalSource = "" },
            new Layout { Data = "007256400400000005010030060000508000008060200000107000030070090200000004006312700", Difficulty = GameDifficulty.Hard, OriginalSource = "" },
            new Layout { Data = "000000000079050180800000007007306800450708096003502700700000005016030420000000000", Difficulty = GameDifficulty.Hard, OriginalSource = "" },

            new Layout { Data = "030000080009000500007509200700105008020090030900402001004207100002000800070000090", Difficulty = GameDifficulty.Hard, OriginalSource = "" },  // 30
            new Layout { Data = "200170603050000100000006079000040700000801000009050000310400000005000060906037002", Difficulty = GameDifficulty.Medium, OriginalSource = "" },
            new Layout { Data = "000000080800701040040020030374000900000030000005000321010060050050802006080000000", Difficulty = GameDifficulty.Hard, OriginalSource = "" },  // 32: Hard
            new Layout { Data = "000000085000210009960080100500800016000000000890006007009070052300054000480000000", Difficulty = GameDifficulty.Medium, OriginalSource = "" },
            new Layout { Data = "608070502050608070002000300500090006040302050800050003005000200010704090409060701", Difficulty = GameDifficulty.Easy, OriginalSource = "" },
            new Layout { Data = "050010040107000602000905000208030501040070020901080406000401000304000709020060010", Difficulty = GameDifficulty.Medium, OriginalSource = "" },
            new Layout { Data = "053000790009753400100000002090080010000907000080030070500000003007641200061000940", Difficulty = GameDifficulty.Easy, OriginalSource = "" },
            new Layout { Data = "006080300049070250000405000600317004007000800100826009000702000075040190003090600", Difficulty = GameDifficulty.Easy, OriginalSource = "" },
            new Layout { Data = "005080700700204005320000084060105040008000500070803010450000091600508007003010600", Difficulty = GameDifficulty.Easy, OriginalSource = "" },
            new Layout { Data = "000900800128006400070800060800430007500000009600079008090004010003600284001007000", Difficulty = GameDifficulty.Easy, OriginalSource = "" },

            new Layout { Data = "000080000270000054095000810009806400020403060006905100017000620460000038000090000", Difficulty = GameDifficulty.Medium, OriginalSource = "" },  // 40
            new Layout { Data = "000602000400050001085010620038206710000000000019407350026040530900020007000809000", Difficulty = GameDifficulty.Easy, OriginalSource = "" },  // ...ish, could almost be medium
            new Layout { Data = "010500200900001000002008030500030007008000500600080004040100700000700006003004050", Difficulty = GameDifficulty.Hard, OriginalSource = "" },
            new Layout { Data = "080000040000469000400000007005904600070608030008502100900000005000781000060000010", Difficulty = GameDifficulty.Hard, OriginalSource = "" },  // 43: Hard
            new Layout { Data = "904200007010000000000706500000800090020904060040002000001607000000000030300005702", Difficulty = GameDifficulty.Hard, OriginalSource = "" },
        };



        #region Working with predefined layouts

        /// <summary>
        /// Randomize a board.
        /// </summary>
        /// <param name="Board"></param>
        public int SetRandomLayout(GameData Board)
        {
            int randomIndex = Randomizer.Next(Layouts.Count);
            SetLayout(Board, randomIndex);

            // Flip vertically
            RandomlyFlipVertically(Board);

            // Flip horizontally
            RandomlyFlipHorizontally(Board);

            // Rotate:
            RandomlyRotate(Board);

            // Replace numbers with other numbers, i.e. shuffle numbers
            ReplaceNumbersOnBoard(Board);

            Board.RefreshAllPossibleValues();

            return randomIndex;
        }

        /// <summary>
        /// Set specified layout to board.
        /// </summary>
        /// <param name="Board"></param>
        /// <param name="LayoutNumber">Number of layout from the list of predefined layouts</param>
        public void SetLayout(GameData Board, int LayoutNumber)
        {
            // Don't test the layout number; let it throw an exception if it is out of bounds
            string tmpString = Layouts[LayoutNumber].Data;
            SetLayoutFromString(Board, tmpString);
        }

        /// <summary>
        /// Helper method to set layout from a string of values; mainly to enable testing by feeding
        /// in specific layouts easily.
        /// </summary>
        /// <param name="Board"></param>
        /// <param name="Layout"></param>
        public void SetLayoutFromString(GameData Board, string Layout)
        {
            Board.Clear();
            if (Layout.Length == 81)
            {
                int i = 0;
                int tmpValue;
                for (int y = 0; y < 9; y++)
                {
                    for (int x = 0; x < 9; x++)
                    {
                        tmpValue = (int)Char.GetNumericValue(Layout[i]);
                        if ((tmpValue < 0) || (tmpValue > 9))
                            throw new Exception("ERROR in setting layouts!");
                        Board.SetFixedCellValue(x, y, tmpValue);
                        i++;
                    }
                }
            }
        }

        #endregion


        /// <summary>
        /// Generate a list of 9 elements, in which each number 1 through 9 exists once but in a random order.
        /// </summary>
        /// <returns></returns>
        public List<int> GenerateRandomNumberSequence()
        {
            List<int> tmpNumbers = new List<int>();
            do
            {
                // Randomize a number:
                int RandomNumber = Randomizer.Next(9) + 1;
                // If it does not already exist in SeededNumbers...
                if (!tmpNumbers.Contains(RandomNumber))
                    tmpNumbers.Add(RandomNumber);  // ...add it
            } while (tmpNumbers.Count < 9);

            return tmpNumbers;
        }

        #region Replacing numbers as tokens for more random variations

        /*
        Numbers can be seen as just tokens; they are swappable, as long as they are swapped
        evenly.For example, any 1's and 2's can be swapped, and the game is still solvable. This
        can be done for example by copying a game to a new grid, replacing existing numbers with
        pre-randomized new ones, as long as all numbers are randomized
        */

        /// <summary>
        /// Randomize numbers by swapping current numbers with different ones, one-to-one. This
        /// makes the board more random but should still keep it solvable
        /// </summary>
        /// <param name="Board"></param>
        public void ReplaceNumbersOnBoard(GameData Board)
        {
            // Randomize a list of 9 numbers, 1 to 9, each one exactly once:
            List<int> RandomList = GenerateRandomNumberSequence();

            // Now go through the board, replacing each number with corresponding number in the list:
            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    if (Board.Data[x, y].Value > 0)
                    {
                        Board.Data[x, y].Value = RandomList[Board.Data[x, y].Value - 1];
                    }
                }
            }
        }

        #endregion


        #region Flipping and rotating the board

        /// <summary>
        /// Randomize a number, 50:50 flip the board vertically
        /// </summary>
        /// <param name="Board"></param>
        private void RandomlyFlipVertically(GameData Board)
        {
            int i = Randomizer.Next(2);
            if (i == 1)
                FlipVertically(Board);
        }


        /// <summary>
        /// Flip board vertically
        /// </summary>
        /// <param name="Board"></param>
        public void FlipVertically(GameData Board)
        {
            GameData tmpBoard = new GameData();
            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    tmpBoard.Data[x, y].Value = Board.Data[8 - x, y].Value;
                    tmpBoard.Data[x, y].Fixed = Board.Data[8 - x, y].Fixed;
                }
            }
            CopyBackFromTemp(Board, tmpBoard);
        }

        private void CopyBackFromTemp(GameData Board, GameData tmpBoard)
        {
            // Copy back from tmpBoard:
            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    Board.Data[x, y].Value = tmpBoard.Data[x, y].Value;
                    Board.Data[x, y].Fixed = tmpBoard.Data[x, y].Fixed;
                }
            }
        }

        /// <summary>
        /// Randomize a number, 50:50 flip board horizontally
        /// </summary>
        /// <param name="Board"></param>
        private void RandomlyFlipHorizontally(GameData Board)
        {
            int i = Randomizer.Next(2);
            if (i == 1)
                FlipHorizontally(Board);
        }


        /// <summary>
        /// Flip board horizontally
        /// </summary>
        /// <param name="Board"></param>
        public void FlipHorizontally(GameData Board)
        {
            GameData tmpBoard = new GameData();
            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    tmpBoard.Data[x, y].Value = Board.Data[x, 8 - y].Value;
                    tmpBoard.Data[x, y].Fixed = Board.Data[x, 8 - y].Fixed;
                }
            }
            CopyBackFromTemp(Board, tmpBoard);
        }

        /// <summary>
        /// Randomize a number from 0 to 3; if more than 0, rotate as many "turns" clockwise as the number indicates
        /// </summary>
        /// <param name="Board"></param>
        private void RandomlyRotate(GameData Board)
        {
            int i = Randomizer.Next(4);
            if (i > 0)
            {
                for (int j = 0; j < i; j++)
                    Rotate(Board);
            }
        }


        /// <summary>
        /// Rotate board counter-clockwise once
        /// </summary>
        /// <param name="Board"></param>
        public void Rotate(GameData Board)
        {
            GameData tmpBoard = new GameData();
            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    tmpBoard.Data[x, y].Value = Board.Data[y, x].Value;
                    tmpBoard.Data[x, y].Fixed = Board.Data[y, x].Fixed;
                }
            }
            CopyBackFromTemp(Board, tmpBoard);
        }

        #endregion


        #region Creating a random layout by seeding one row and shifting rows from there
        /*
             2: A game can be semi-randomized by
                2.1: randomizing all numbers to row 1
                2.3: shift all numbers by 3, creating the next row
                2.4: same shift for row 3
                2.5: shift only once for row 4
                2.6: then 3 times for rows 5 and 6
                2.7: and again 1 shift for row 7, three shifts for rows 8 and 9, like this:

                    line 1: 8 9 3  2 7 6  4 5 1
                    line 2: 2 7 6  4 5 1  8 9 3 (shift 3)
                    line 3: 4 5 1  8 9 3  2 7 6 (shift 3)

                    line 4: 5 1 8  9 3 2  7 6 4 (shift 1)
                    line 5: 9 3 2  7 6 4  5 1 8 (shift 3)
                    line 6: 7 6 4  5 1 8  9 3 2 (shift 3)

                    line 7: 6 4 5  1 8 9  3 2 7 (shift 1)
                    line 8: 1 8 9  3 2 7  6 4 5 (shift 3)
                    line 9: 3 2 7  6 4 5  1 8 9 (shift 3)

                2.8: Now start removing random cells, until game can't be solved anymore
                2.9: return the last removed cell -> solvable random game
                2.10: Note that the random layout can be rotated and flipped before starting to remove cells, to
                      create even more randomized variations
        */
        public void SetSeededRandomLayout(GameData Board)
        {
            Board.Clear();

            // Randomize first row:
            RandomizeFirstRow(Board);

            // Fill in all the rest of the rows with shifted values
            FillBoardWithShiftedRows(Board);

            // Start removing values until can't solve no more, and then return the last removed value
            RemoveRandomValuesUntilJustSolvable(Board, 1);

            // Mark all remaining values as fixed
            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    Board.Data[x, y].Fixed = (Board.Data[x, y].Value > 0);
                }
            }

            // Flip, rotate and swap numbers to hide the shifted form
            RandomlyFlipVertically(Board);
            RandomlyFlipHorizontally(Board);
            RandomlyRotate(Board);
            ReplaceNumbersOnBoard(Board);

            // Refresh it:
            Board.RefreshAllPossibleValues();
        }


        /// <summary>
        /// When the first row is filled by all values 1 to 9, the rest of the rows can be 
        /// filled in by shifting the values from one row to another. This is a separate method
        /// to enable testing the result
        /// </summary>
        /// <param name="Board"></param>
        public void FillBoardWithShiftedRows(GameData Board)
        {
            CreateShiftedRow(Board, 1, 2, 3);  // Shift second row by 3 steps
            CreateShiftedRow(Board, 2, 3, 3);  // Shift third row by 3 steps

            CreateShiftedRow(Board, 3, 4, 1);  // Shift fourth row by 1 step
            CreateShiftedRow(Board, 4, 5, 3);  // Shift fifth row by 3 steps
            CreateShiftedRow(Board, 5, 6, 3);  // Shift sixth row by 3 steps

            CreateShiftedRow(Board, 6, 7, 1);  // Shift seventh row by 1 step
            CreateShiftedRow(Board, 7, 8, 3);  // Shift eighth row by 3 steps
            CreateShiftedRow(Board, 8, 9, 3);  // Shift nineth row by 3 steps
        }


        /// <summary>
        /// Create randomized first row of board; assumed that the board has been cleared in advance.
        /// </summary>
        /// <param name="Board"></param>
        public void RandomizeFirstRow(GameData Board)
        {
            List<int> SeededNumbers = GenerateRandomNumberSequence();

            // Now assign the first row to grid:
            for (int i = 0; i < 9; i++)
            {
                Board.Data[i, 0].Value = SeededNumbers[i];
            }
        }


        /// <summary>
        /// Take a row of values from boar. Shift values "ShiftCount" steps to right, forming target row.
        /// </summary>
        /// <param name="Board">Board to work on</param>
        /// <param name="SeedRow">Row to use as basis of values</param>
        /// <param name="TargetRow">Row to fill with shifted values</param>
        /// <param name="ShiftCount">How many steps to shift</param>
        public void CreateShiftedRow(GameData Board, int SeedRow, int TargetRow, int ShiftCount)
        {
            // Do nothing if values are out of possible:
            if (SeedRow < 1 || SeedRow > 9)
                return;
            if (TargetRow < 1 || TargetRow > 9)
                return;
            if (ShiftCount < 1 || ShiftCount > 8)
                return;
            if (SeedRow == TargetRow)
                return;

            int TargetRowX = ShiftCount;

            // Go through the SeedRow cells
            for (int SeedRowX = 0; SeedRowX < 9; SeedRowX++)
            {
                Board.Data[TargetRowX, TargetRow - 1].Value = Board.Data[SeedRowX, SeedRow - 1].Value;

                // Advance target row X by one, looping back to beginning if it rolls over:
                TargetRowX++;
                if (TargetRowX > 8)
                    TargetRowX = 0;
            }
        }


        /// <summary>
        /// Remove values from cells until the board is no longer solvable. Then return last X
        /// removed values to make the board solvable again.
        /// </summary>
        /// <param name="Board"></param>
        /// <param name="HelperValueCount">How many values to return after removing, to make the board 
        /// solvable. This can be considered somewhat a "difficulty" value; the smaller the value, the
        /// harder it will be to solve the grid.</param>
        public void RemoveRandomValuesUntilJustSolvable(GameData Board, int HelperValueCount)
        {
            // This list will contain the removed cells
            List<UndoAction> RemovedList = new List<UndoAction>();

            // Create a list of 9 random numbers. Cells will be removed from rows of this number, to 
            // make the removal more even:
            List<int> RemovalRowOrder = GenerateRandomNumberSequence();

            bool FoundCellToRemove;
            int x;
            int y = 0;

            do
            {
                // Remove a cell value:
                FoundCellToRemove = false;
                do
                {
                    x = Randomizer.Next(9);
                    //y = Randomizer.Next(9);
                    if (Board.Data[x, RemovalRowOrder[y] - 1].Value > 0)
                        FoundCellToRemove = true;
                } while (FoundCellToRemove == false);

                // [x, y] now points to a cell that can be removed. Remove it, adding the removal to 
                // the RemovedList:
                UndoAction removed = new UndoAction
                {
                    Value = Board.Data[x, RemovalRowOrder[y] - 1].Value,
                    x = x,
                    y = RemovalRowOrder[y] - 1
                };
                RemovedList.Add(removed);
                Board.Data[x, RemovalRowOrder[y] - 1].Value = 0;

                // Next time, move from another row:
                y++;
                if (y > 8)
                    y = 0;
            } while (Board.TrySolveAll());

            // Ok, now the board can no longer be solved. Now roll back HelerpValueCount worth 
            // of removed values:
            for (int i = 0; i < HelperValueCount; i++)
            {
                UndoAction RollBackcell = RemovedList[RemovedList.Count - 1];
                Board.Data[RollBackcell.x, RollBackcell.y].Value = RollBackcell.Value;
                RemovedList.Remove(RollBackcell);
            }
        }

        #endregion
    }
}
