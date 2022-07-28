using Games.Data.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    public class Game1 : IGame1
    {
        private IDrawer _drawer;
        private IDataService _dataService;
        private IRockPaperScissorsDeepLogic _rockPaperScissorsDeepLogic;

        public Game1(IDrawer drawer, IDataService dataService, 
            IRockPaperScissorsDeepLogic rockPaperScissorsDeepLogic)
        {
            _drawer = drawer;
            _dataService = dataService;
            _rockPaperScissorsDeepLogic = rockPaperScissorsDeepLogic;
            _rockPaperScissorsDeepLogic.OutcomeEvent += OnOutcomeEvent;

        }

        private void OnOutcomeEvent(object sender, OutcomeEventArgs e)
        {
            Console.WriteLine(e.Feedback);
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
            Console.WriteLine();
            DiffPicker();
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("Let's begin the game! ");
            Console.WriteLine();
            GameLoop();


        }

        private void DiffPicker()
        {
            var pick = Console.ReadKey();
            bool result = char.TryParse(pick.KeyChar.ToString(), out char picked);
            if (result == false)
            {
                Console.WriteLine("Wrong selection given");
                Console.WriteLine("Setting default difficulty");
                _dataService.SetDifficulty('n');
                return;
            }
            _dataService.SetDifficulty(picked);
        }

        private void GameLoop()
        {
            while (true)
            {
                //Console.Clear();
                Console.WriteLine("To select move press correspondiong letter: ");
                Console.WriteLine("For [paper] - press 'p' ");
                Console.WriteLine("For [scissors] - press 's' ");
                Console.WriteLine("For [rock] - press 'r' ");
                var selection = Console.ReadLine();
                _dataService.PickInterpreter(selection);

            }
        }

    }
}
