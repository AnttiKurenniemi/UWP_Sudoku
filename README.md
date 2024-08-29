# Sudoku game in UWP / C#

This is one version of my Sudoku game from years back, originally from .net 2.x and now ported to .net 8. The code is a delightful mess from along the years, with several styles and ideas I've picked up along the way - I can't be arsed to clean it up, so it is what it is.

The game is on WinForms and thus Windows only. The UI is made up of a custom control with manual drawing of the grid and numbers and everything. There are a bunch of predefined Sudoku layouts in the game, and it can randomize a layout. The solving engine uses a logic approach to check if the game can be solved, and for solving the whole game board. It's not super advanced so it might not be able to solve everything that is solvable, but... meh.
