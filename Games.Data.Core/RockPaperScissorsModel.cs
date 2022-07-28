using System;

namespace Games.Data.Core
{
    public class RockPaperScissorsModel
    {
        public double Score { get; set; }
        public int Loses { get; set; }
        public int Wins { get; set; }
        public int Draws { get; set; }
        public double LosesValue { get; set; }
        public double WinsValue { get; set; }

    }
}
