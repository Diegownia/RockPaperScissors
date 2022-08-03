using Games.Data.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CoreGame
{
    public class Game1 : IGame1
    {
        private IDrawer _drawer;
        private IGameManager _gameManager;
        private IRockPaperScissorsDeepLogic _rockPaperScissorsDeepLogic;
        private IRockPaperScissorsModel _rockPaperScissorsModel;

        public Game1(IDrawer drawer, IGameManager gameManager, 
            IRockPaperScissorsDeepLogic rockPaperScissorsDeepLogic,
            IRockPaperScissorsModel rockPaperScissorsModel)
        {
            _drawer = drawer;
            _gameManager = gameManager;
            _rockPaperScissorsDeepLogic = rockPaperScissorsDeepLogic;
            _rockPaperScissorsModel = rockPaperScissorsModel;
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
            Console.WriteLine("Before you begin please pick the difficulty");
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
                _gameManager.SetDifficulty('n');
                return;
            }
            _gameManager.SetDifficulty(picked);
        }

        private void GameLoop()
        {
            while (true)
            {
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("Current score: ");
                Console.WriteLine($"Wins: {_rockPaperScissorsModel.Wins}");
                Console.WriteLine($"Loses: {_rockPaperScissorsModel.Loses}");
                Console.WriteLine($"Draws: {_rockPaperScissorsModel.Draws}");
                Console.WriteLine($"Score: {_rockPaperScissorsModel.Score}");
                Console.WriteLine("To select move press correspondiong letter: ");
                Console.WriteLine("For [paper] - press 'p' ");
                Console.WriteLine("For [scissors] - press 's' ");
                Console.WriteLine("For [rock] - press 'r' ");
                var selection = Console.ReadLine().ToLower();
                if (selection == "q")
                {
                    break;
                }
                _gameManager.PickInterpreter(selection);

            }
        }

    }
}
