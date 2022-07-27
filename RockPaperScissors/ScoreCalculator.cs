using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    public class ScoreCalculator : IScoreCalculator
    {
        public double LosesValue { get; set; }
        public double WinsValue { get; set; }
        public double CountScore(int wins, int loses)
        {
            var score = (wins * WinsValue) - (loses * LosesValue);
            return score;
        }
    }
}
