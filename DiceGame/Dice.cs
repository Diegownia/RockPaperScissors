using Games.Data.Core;
using System;

namespace DiceGame
{
    public class Dice
    {
        private IGameManager _gameManager;
        public Dice(IGameManager gameManager)
        {
            _gameManager = gameManager;
        }
        public void DiceGame()
        {
            Console.WriteLine("Welcome to the Dice Game! ");
            Console.WriteLine("First let's pick the amount of rounds! ");
            _gameManager.RoundSetter(_gameManager.GetIntergerFromUserInput());
            //TO DO Round counter
        }


        private void GameLoop()
        {
            while (true)
            {

            }
        }
    }
}
