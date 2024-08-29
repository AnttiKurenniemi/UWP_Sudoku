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
    public class GameLayoutsTests
    {
        #region Overall tests to quickly validate predefined data

        /// <summary>
        /// Dummy stuff; make sure all layouts have exactly 81 characters, just to weed out any possible typos.
        /// </summary>
        [TestMethod()]
        public void Check_length_of_each_layout_string()
        {
            GameLayouts layouts = new GameLayouts();
            for (int i = 0; i < layouts.Layouts.Count(); i++)
            {
                Assert.AreEqual(81, layouts.Layouts[i].Data.Length);
            }
        }


        /// <summary>
        /// Test each layout that they are solvable.
        /// </summary>
        [TestMethod()]
        public void SetRandomLayout_check_that_each_predefined_layout_is_solvable()
        {

            GameData Board = new GameData();
            GameLayouts layouts = new GameLayouts();
            for (int BoardNumber = 0; BoardNumber < layouts.Layouts.Count(); BoardNumber++)
            {
                layouts.SetLayout(Board, BoardNumber);
                Assert.AreEqual(true, Board.SolveAll(), "Could not solve board #" + BoardNumber.ToString() + ": " + Board.ToString());
            }

        }


        [TestMethod()]
        public void IsDigitsOnly_flags_string_with_characters_as_false()
        {
            HelperMethods helper = new HelperMethods();
            Assert.AreEqual(false, helper.IsDigitsOnly("123a456"));
        }

        [TestMethod()]
        public void IsDigitsOnly_returns_true_for_plain_digit_string()
        {
            HelperMethods helper = new HelperMethods();
            Assert.AreEqual(true, helper.IsDigitsOnly("123456"));
        }

        [TestMethod()]
        public void IsDigitsOnly_returns_true_for_empty_string()
        {
            HelperMethods helper = new HelperMethods();
            Assert.AreEqual(true, helper.IsDigitsOnly(""));
        }

        [TestMethod()]
        public void IsDigitsOnly_returns_true_for_null_string()
        {
            HelperMethods helper = new HelperMethods();
            Assert.AreEqual(true, helper.IsDigitsOnly(null));
        }


        [TestMethod()]
        public void IsZeroOrOneOnly_returns_false_when_string_contains_characters()
        {
            HelperMethods helper = new HelperMethods();
            Assert.IsFalse(helper.IsZeroOrOneOnly("01abc01"));
        }

        [TestMethod()]
        public void IsZeroOrOneOnly_returns_false_when_string_contains_other_numbers()
        {
            HelperMethods helper = new HelperMethods();
            Assert.IsFalse(helper.IsZeroOrOneOnly("01201"));
        }

        [TestMethod()]
        public void IsZeroOrOneOnly_returns_true_when_string_is_empty()
        {
            HelperMethods helper = new HelperMethods();
            Assert.IsTrue(helper.IsZeroOrOneOnly(""));
        }

        [TestMethod()]
        public void IsZeroOrOneOnly_returns_true_when_string_is_null()
        {
            HelperMethods helper = new HelperMethods();
            Assert.IsTrue(helper.IsZeroOrOneOnly(null));
        }

        [TestMethod()]
        public void IsZeroOrOneOnly_returns_true_for_single_digit_string_1()
        {
            HelperMethods helper = new HelperMethods();
            Assert.IsTrue(helper.IsZeroOrOneOnly("1"));
        }

        [TestMethod()]
        public void IsZeroOrOneOnly_returns_true_for_single_digit_string_0()
        {
            HelperMethods helper = new HelperMethods();
            Assert.IsTrue(helper.IsZeroOrOneOnly("0"));
        }

        [TestMethod()]
        public void IsZeroOrOneOnly_returns_true_for_valid_string()
        {
            HelperMethods helper = new HelperMethods();
            Assert.IsTrue(helper.IsZeroOrOneOnly("010101010101010101010101010101010101010101010101010101010101010101010101010101010"));
        }



        /// <summary>
        /// Make sure all predefined layouts that are stored as strings, only contain numbers 0 through 9.
        /// </summary>
        [TestMethod()]
        public void Check_that_all_layouts_contain_only_valid_characters()
        {
            HelperMethods helper = new HelperMethods();
            GameLayouts lts = new GameLayouts();
            bool IsValid = true;

            for (int i = 0; i < lts.Layouts.Count(); i++)
            {
                IsValid = helper.IsDigitsOnly(lts.Layouts[i].Data);
                if (IsValid == false)
                {
                    break;
                }
            }
            Assert.AreEqual(true, IsValid);
        }


        /// <summary>
        /// Because layouts are added from here and there, it is possible that the same layout gets added multiple
        /// times. This method simply checks that no two are exatcly the same.
        /// </summary>
        [TestMethod()]
        public void Check_for_duplicate_layouts()
        {
            GameLayouts lts = new GameLayouts();
            bool IsValid = true;
            string ErrorMessage = "";

            for (int i = 0; i < lts.Layouts.Count() - 1; i++)
            {
                for (int j = i + 1; j < lts.Layouts.Count(); j++)
                {
                    if (lts.Layouts[i] == lts.Layouts[j])
                    {
                        IsValid = false;
                        ErrorMessage = string.Format("Layouts {0} and {1} are the same: {2}", i, j, lts.Layouts[i].ToString());
                        break;
                    }
                }
            }
            Assert.AreEqual(true, IsValid, ErrorMessage);
        }

        #endregion


        #region BoardToString tests

        [TestMethod()]
        public void BoardToString_returns_a_full_row_of_empty_values_from_an_empty_grid()
        {
            GameData Board = new GameData();
            Assert.AreEqual("000000000000000000000000000000000000000000000000000000000000000000000000000000000", Board.ToString());
        }

        [TestMethod()]
        public void BoardToString_when_given_string_as_layout_returns_same_ToString()
        {
            GameData Board = new GameData();
            GameLayouts Layouts = new GameLayouts();
            Layouts.SetLayoutFromString(Board, "123456789123456789123456789123456789123456789123456789123456789123456789123456789");
            Assert.AreEqual("123456789123456789123456789123456789123456789123456789123456789123456789123456789", Board.ToString());

            Layouts.SetLayoutFromString(Board, "043080250600000000000001094900004070000608000010200003820500000000000005034090710");
            Assert.AreEqual("043080250600000000000001094900004070000608000010200003820500000000000005034090710", Board.ToString());
        }

        #endregion


        #region Vertically flipping tests

        [TestMethod()]
        public void FlipVertically_returns_correctly_flipped_board()
        {
            GameData Board = new GameData();
            GameLayouts Layouts = new GameLayouts();

            // Set a specific layout
            Layouts.SetLayoutFromString(Board, "123456789123456789123456789123456789123456789123456789123456789123456789123456789");

            // Flip it
            Layouts.FlipVertically(Board);

            // Check if it was ok
            Assert.AreEqual("987654321987654321987654321987654321987654321987654321987654321987654321987654321", Board.ToString());
        }

        #endregion


        #region Horizontally flipping tests

        [TestMethod()]
        public void FlipHorizontally_returns_correctly_flipped_board()
        {
            GameData Board = new GameData();
            GameLayouts Layouts = new GameLayouts();

            // Set a specific layout
            Layouts.SetLayoutFromString(Board, "111111111222222222333333333444444444555555555666666666777777777888888888999999999");

            // Flip it
            Layouts.FlipHorizontally(Board);

            // Check if it was ok
            Assert.AreEqual("999999999888888888777777777666666666555555555444444444333333333222222222111111111", Board.ToString());
        }

        #endregion


        #region Rotate tests

        [TestMethod()]
        public void Rotate_rotating_once_produces_correctly_rotated_board_layout()
        {
            GameData Board = new GameData();
            GameLayouts Layouts = new GameLayouts();

            // Set a specific layout
            Layouts.SetLayoutFromString(Board, "111111111222222222333333333444444444555555555666666666777777777888888888999999999");

            // Rotate
            Layouts.Rotate(Board);

            // Check:
            Assert.AreEqual("123456789123456789123456789123456789123456789123456789123456789123456789123456789", Board.ToString());
        }

        [TestMethod()]
        public void Rotate_rotating_four_times_produces_original_board_layout()
        {
            GameData Board = new GameData();
            GameLayouts Layouts = new GameLayouts();

            // Set a specific layout
            Layouts.SetLayoutFromString(Board, "111111111222222222333333333444444444555555555666666666777777777888888888999999999");

            // Rotate four times
            Layouts.Rotate(Board);
            Layouts.Rotate(Board);
            Layouts.Rotate(Board);
            Layouts.Rotate(Board);

            // Check:
            Assert.AreEqual("111111111222222222333333333444444444555555555666666666777777777888888888999999999", Board.ToString());
        }

        #endregion
    }
}
