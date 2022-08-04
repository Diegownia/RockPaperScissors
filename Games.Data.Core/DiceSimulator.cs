using System;
using System.Collections.Generic;
using System.Text;

namespace Games.Data.Core
{
    public class DiceSimulator : IDiceSimulator
    {
        private readonly IDrawer _drawer;

        public DiceSimulator(IDrawer drawer)
        {
            _drawer = drawer;
        }


        public int ThrowDice()
        {
            Random side = new Random();
            return side.Next(1, 6);
        }
    }
}
