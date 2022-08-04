using DiceGame;
using Games.Data.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreGame
{
    public class MainMenu : IMainMenu
    {
        private readonly IGame1 _game1;
        private readonly IDrawer _drawer;
        private readonly IDice _dice;
        public MainMenu(IGame1 game1, IDrawer drawer, IDice dice)
        {
            _game1  = game1;
            _drawer = drawer;
            _dice = dice;
        }

        public void Welcome()
        {
            _drawer.DrawWelcomeScreen();
            Console.WriteLine("Pick a game: ");
            Console.WriteLine("Game list: ");
            Console.WriteLine("1 - Rock Paper Scissors");
            Console.WriteLine("2 - Dice Game");
            Console.WriteLine("3 - Guess a number");
            var pick = Console.ReadKey();
            bool result = int.TryParse(pick.KeyChar.ToString(), out int picked);
            if (result == false)
            {
                Console.WriteLine("Wrong selection ");
                Console.Clear();
                return;
            };

            switch (picked)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("You've picked Rock Paper Scissors! Enjoy");
                    _game1.RockPaperScissorsGame();
                    Console.Clear();
                    Console.WriteLine("Hope the game was fun");
                    Welcome();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("You've picked Dice game! Enjoy!");
                    _dice.DiceGame();
                    Console.Clear();
                    Console.WriteLine("Hope the game was fun");
                    Welcome();
                    break;

            }
        }

    }


}
