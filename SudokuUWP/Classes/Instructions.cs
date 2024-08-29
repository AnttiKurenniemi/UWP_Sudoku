using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace SudokuUWP.Classes
{
    public class Instructions
    {
        public async static void ShowHowToPlay()
        {
            bool HowToPlayShown = GameSettings.GetBoolValue("HowToPlayShown", false);

            if (!HowToPlayShown)
            {
                var dialog = new MessageDialog("\nSelect 'Start new game' from the buttons on the right hand side, to" +
                    " begin a new game. Click on a cell and press a number (1 - 9) on the keyboard to set a number in" +
                    " that cell.\n\n" +
                    " Press 0, or backspace or delete to clear a value from a cell.\n\n" +
                    "Gray numbers are the initial numbers the game is started with. Black numbers are set by you. Green numbers are" +
                    " numbers completely solved. Blue color highlights all cells with the same number as the currently selected cell.\n\n" +
                    "You can also double-click an empty cell, to assign the same number as the previously selected cell.\n\n" +
                    "Don't forget to enjoy!");
                dialog.Title = "How to play";
                dialog.Commands.Add(new UICommand { Label = "Cool, let me at it!", Id = 0 });
                await dialog.ShowAsync();

                GameSettings.SaveValue("HowToPlayShown", true);
            }
        }
    }
}
