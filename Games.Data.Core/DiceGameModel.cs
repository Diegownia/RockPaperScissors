using System;
using System.Collections.Generic;
using System.Text;

namespace Games.Data.Core
{
    public class DiceGameModel : IDiceGameModel
    {
        public int PlayerScore { get; set; }
        public int PcScore { get; set; }
        public int Rounds { get; set; }

    }
}
