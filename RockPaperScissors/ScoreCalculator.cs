﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    public class ScoreCalculator : IScoreCalculator
    {
        private IRockPaperScissorsModel _rockPaperScissorsModel;

        public ScoreCalculator(IRockPaperScissorsModel rockPaperScissorsModel)
        {
            _rockPaperScissorsModel = rockPaperScissorsModel;
        }

        public double LosesValue { get; set; }
        public double WinsValue { get; set; }
        public double CountScore(int wins, int loses)
        {
            var score = (wins * _rockPaperScissorsModel.WinsValue) - 
                (loses * _rockPaperScissorsModel.LosesValue);
            return score;
        }
    }
}
