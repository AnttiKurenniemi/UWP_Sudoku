using SudokuUWP.Classes;
using System;
using System.Collections.ObjectModel;
using Windows.UI.Core;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Microsoft.AppCenter.Analytics;
using Windows.ApplicationModel;
using Windows.UI.Xaml.Media;
using Windows.UI;
using SudokuUWP.Library;

namespace SudokuUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        GameController gameController = new GameController();

        // Collection of cell objects for binding to the grid
        public ObservableCollection<Cell> Cells;

        private enum SolvableState { None, Solvable, NotSolvable };
        private SolvableState solvableState = SolvableState.None;
            
        public MainPage()
        {
             Cells = gameController.GetCells();
             this.InitializeComponent();

             SetCompletedTextVisibility(Visibility.Collapsed);
             
             Window.Current.CoreWindow.KeyDown += MainPage_KeyDown;
        }


        /// <summary>
        /// Page loaded. Set up the version number display, and show "how to play" dialog if running for the first time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            // Application version:
            Package package = Package.Current;
            PackageId packageId = package.Id;
            PackageVersion version = packageId.Version; ApplicationVersionLabel.Text = string.Format("Version {0}.{1}.{2}.{3}", 
                version.Major, version.Minor, version.Build, version.Revision);
            Instructions.ShowHowToPlay();
        }


        /// <summary>
        /// Display or hide the "hame completed" text, overlay border and the quote
        /// </summary>
        /// <param name="value"></param>
        private void SetCompletedTextVisibility(Visibility value)
        {
            GameCompletedBorder.Visibility = value;
            if (value == Visibility.Visible)
            {
                // Game appears to be solved; make the actual game grid barely visible
                GameGrid.Opacity = 0.2;
            }
            else
            {
                GameGrid.Opacity = 1;
            }
        }

        

        /// <summary>
        /// Check if the game is solvable; green or red border, or transparent if the board is empty
        /// </summary>
        private async void SetSolvable()
        {
            if ((gameController.IsEmpty()) && (solvableState != SolvableState.None))
            {
                MainBorder.BorderBrush = new SolidColorBrush(Colors.Transparent);
                solvableState = SolvableState.None;
            }
            else
            if (await gameController.TrySolveAsync())
                SetSolvable(true);
            else
                SetSolvable(false);
        }

        /// <summary>
        /// Set the solvable hint border color to green or red
        /// </summary>
        /// <param name="IsSolvable"></param>
        private void SetSolvable(bool IsSolvable)
        {
            if ((IsSolvable) && (solvableState != SolvableState.Solvable))
            {
                // Solvable - set border to green:
                colorStoryboard.Stop();
                MainBorder.BorderBrush = new SolidColorBrush(Colors.LightGreen);
                solvableState = SolvableState.Solvable;
            }
            else if ((!IsSolvable) && (solvableState != SolvableState.NotSolvable))
            {
                // Error, can't solve - animate border between red and pink:
                colorStoryboard.Begin();
                solvableState = SolvableState.NotSolvable;
            }
        }


        /// <summary>
        /// Clear all cells
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearAllButton_Click(object sender, RoutedEventArgs e)
        {
            SetCompletedTextVisibility(Visibility.Collapsed);

#if DEBUG
            var appView = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView();
            appView.Title = "";
#endif
            gameController.Clear();
            SetSolvable();
        }


        /// <summary>
        /// Initialise a random preset value to all cells
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetRandomPresetButton_Click(object sender, RoutedEventArgs e)
        {
#if DEBUG
            // If debugging, check if there are unknown difficulty games; if so, select one of those:
            if (gameController.UnknownDifficultCount() > 0)
            {
                SetRandomUnknownDifficultyPreset();
                return;
            }
#endif
            SetCompletedTextVisibility(Visibility.Collapsed);
            
            gameController.SetRandomPreset();
            SetSolvable();
            Analytics.TrackEvent("New random preset game started");
#if DEBUG
            // Display the game number if debugging
            var appView = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView();
            appView.Title = string.Format("Game index: {0} ({1})",
                gameController.currentLayoutIndex.ToString(),
                gameController.currentLayoutDifficulty.ToString());
#endif
        }


        /// <summary>
        /// FOR TESTING / DEBUG ONLY!
        /// Find a random game that has not been solved.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetRandomUnknownDifficultyPreset()
        {
            SetCompletedTextVisibility(Visibility.Collapsed);

            gameController.SetRandomUnknownPreset();
            SetSolvable();

            // Display the game number if debugging
            var appView = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView();
            appView.Title = string.Format("Game index: {0} ({1})",
                gameController.currentLayoutIndex.ToString(),
                gameController.currentLayoutDifficulty.ToString());
        }


        /// <summary>
        /// Cell clicked; set that cell to selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Border_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (gameController.Solved)
                return;

            gameController.SetSelectedCell((Border)sender);
        }


        /// <summary>
        /// Set cell value to a previous value, IF a previous value is set
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Border_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            if (!gameController.IsEmpty())
            {
                gameController.AssignLastUsedValueToCell((Border)sender);
                if (gameController.Solved)
                    GameCompleted(true);
                else
                    SetSolvable();
            }
        }

        /// <summary>
        /// Key press event. If a cell is selected, set a value or move the cursor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void MainPage_KeyDown(CoreWindow sender, KeyEventArgs args)
        {
            if (gameController.Solved)
                return;

            gameController.AssignCellValue(args);
            gameController.ValidateGame();
            if (gameController.Solved)
                GameCompleted(true);
            else
                SetSolvable();
        }


        /// <summary>
        /// Attempt to solve the game by using the game engine
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void SolveGameButton_Click(object sender, RoutedEventArgs e)
        {
            if (gameController.IsEmpty())
                return;

            // Do not allow re-solving, EXCEPT in debug buid - it is handy for checking the game over
            // quotes over and over again.
#if !DEBUG
            if (gameController.Solved)
                return;
#endif

            gameController.SolveGame();
            if (gameController.Solved)
                GameCompleted(false);
            else
            {
                // Unable to solve - TODO: Also check for an empty board:
                SetSolvable(false);  // False because we KNOW it is not solvable
                var dialog = new MessageDialog("I was not able to solve the game. This could indicate that the game is not solvable by simple logic.");
                await dialog.ShowAsync();
            }
        }


        /// <summary>
        /// Give a single cell hint, if possible.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void GiveHintButton_Click(object sender, RoutedEventArgs e)
        {
            if (gameController.IsEmpty())
                return;

            if (!gameController.Solved)
            {
                if (!gameController.SolveSingleHintCell())
                {
                    SetSolvable(false);
                    var dialog = new MessageDialog("I was not able to solve a single cell. This could indicate that the game is not solvable by simple logic.");
                    await dialog.ShowAsync();
                }
                else
                {
                    // Check if it was fully solved:
                    if (gameController.Solved)
                        GameCompleted(false);
                    else
                        SetSolvable();
                }
            }
        }


        /// <summary>
        /// Undo button click; undo a move (if any moves in the undo stack).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UndoButton_Click(object sender, RoutedEventArgs e)
        {
            if (gameController.Solved)
                return; 

            gameController.UndoMove();
            SetSolvable();
        }

        
        /// <summary>
        /// When a game is completed, display the "wowza" text and track the event in App Center
        /// </summary>
        /// <param name="CompletedByUser"></param>
        private void GameCompleted(bool CompletedByUser)
        {
            GameCompletedText.Text = QuoteList.GetRandomWowza();

            Quote quote = QuoteList.GetRandomQuote();
            QuoteText.Text = "\"" + quote.Text + "\"";
            QuoteAuthor.Text = quote.Author;

            SetCompletedTextVisibility(Visibility.Visible);
#if !DEBUG
            if (CompletedByUser)
                Analytics.TrackEvent("Game completed");
            else
                Analytics.TrackEvent("Game completed by engine");
#endif
        }


        /// <summary>
        /// Show instructions page (frame)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InstructionsButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(InstructionsPage));
        }

    }
}
