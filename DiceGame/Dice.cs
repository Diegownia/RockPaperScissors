using Games.Data.Core;
using System;
using System.Threading;

namespace DiceGame
{
    public class Dice : IDice
    {
        private IGameManager _gameManager;
        private IDiceGameModel _diceGameModel;
        private IDrawer _drawer;
        public Dice(IGameManager gameManager, IDiceGameModel diceGameModel,
            IDrawer drawer)
        {
            _gameManager = gameManager;
            _diceGameModel = diceGameModel;
            _drawer = drawer;
        }
        public void DiceGame()
        {
            Console.WriteLine("Welcome to the Dice Game! ");
            Console.WriteLine("First let's pick the amount of rounds! ");
            _gameManager.RoundSetter(_gameManager.GetIntergerFromUserInput());
            GameLoop();
        }


        private void GameLoop()
        {
            while (_diceGameModel.Rounds != 0)
            {
                _drawer.DrawDiceIntro();
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine($"Rounds left: {_diceGameModel.Rounds}");
                Console.WriteLine("Time for your throw! ");
                Console.WriteLine("Press Enter to continue! ");
                _gameManager.GetEnterFromUser();
                GameResolver();

            }

            Console.WriteLine("Round is over. ");
            FindWinnerOfTheRound();
            Console.WriteLine("press any key to leave!");
            Console.ReadKey();
            Console.Clear();
        }

        private void GameResolver()
        {
            switch (_gameManager.DiceThrower())
            {
                case 'p':
                    Console.WriteLine("You won!");
                    break;
                case 'c':
                    Console.WriteLine("Computer won!");
                    break;
                case 'd':
                    Console.WriteLine("It's a draw");
                    break;
            }
        }

        private void FindWinnerOfTheRound()
        {
            switch (_gameManager.DiceScoreCounter())
            {
                case 'p':
                    Console.WriteLine("Congratulations! You won!");
                    Console.WriteLine($"Your score is {_diceGameModel.PlayerScore}");
                    break;
                case 'c':
                    Console.WriteLine("You've lost...");
                    Console.WriteLine($"PC Score is: {_diceGameModel.PcScore}");
                    break;
                case 'd':
                    Console.WriteLine("It's a draw!");
                    break;
            }
        }
    }
}
