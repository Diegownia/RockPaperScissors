using Games.Data.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Games.Data.Core
{
    public class ScoreCalculator : IScoreCalculator
    {
        private IRockPaperScissorsModel _rockPaperScissorsModel;

        public ScoreCalculator(IRockPaperScissorsModel rockPaperScissorsModel)
        {
            _rockPaperScissorsModel = rockPaperScissorsModel;
        }

        public void CountScore(int wins, int loses)
        {
            _rockPaperScissorsModel.Score = (wins * _rockPaperScissorsModel.WinsValue) - 
                (loses * _rockPaperScissorsModel.LosesValue);
        }
    }
}
