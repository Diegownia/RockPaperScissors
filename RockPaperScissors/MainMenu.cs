using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    public class MainMenu : IMainMenu
    {
        private readonly IGame1 _game1;
        private readonly IDrawer _drawer;
        public MainMenu(IGame1 game1, IDrawer drawer)
        {
            _game1  = game1;
            _drawer = drawer;
        }

        public void Welcome()
        {
            _drawer.DrawWelcomeScreen();
            Console.WriteLine("Pick a game: ");
            var pick = Console.ReadKey();
            bool result = int.TryParse(pick.KeyChar.ToString(), out int picked);
            if (result == false)
            {
                Console.WriteLine("Wrong selection ");
                return;
            };

            switch (picked)
            {
                case 1:
                    Console.WriteLine("You've picked Rock Paper Scissors! Enjoy");

                    break;

            }
        }

    }


}
