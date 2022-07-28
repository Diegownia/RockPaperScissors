using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    public class Game1 : IGame1
    {
        private IDrawer _drawer;
        private IDataService _dataService;

        public Game1(IDrawer drawer, IDataService dataService)
        {
            _drawer = drawer;
            _dataService = dataService;
        }
        public void RockPaperScissorsGame()
        {
            Console.WriteLine("Welcome to the game of Rock Paper Scissors: ");
            Console.WriteLine();
            Console.WriteLine();
            _drawer.DrawRockPaperScissors();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Before you begin please pick th difficulty");
            Console.WriteLine("For [e]asy - press 'e'");
            Console.WriteLine("For [n]ormal - press 'n'");
            Console.WriteLine("For [h]ard - press 'h'");
            DiffPicker();

            
        }


        private void DiffPicker()
        {
            var pick = Console.ReadKey();
            bool result = char.TryParse(pick.KeyChar.ToString(), out char picked);
            _dataService.SetDifficulty(picked);

        }

    }
}
