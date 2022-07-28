using System;
using System.Collections.Generic;
using System.Text;

namespace Games.Data.Core
{
    public class DataService
    {
        private IRockPaperScissorsModel _rockPaperScissorsModel;
        public DataService(IRockPaperScissorsModel rockPaperScissorsModel)
        {
            _rockPaperScissorsModel = rockPaperScissorsModel;
        }
        public void SetDifficulty(char diffinput)
        {
            if (diffinput == 'e')
            {
                _rockPaperScissorsModel.WinsValue = 1.5;
                _rockPaperScissorsModel.LosesValue = 0.5;
            }
            if (diffinput == 'n')
            {
                _rockPaperScissorsModel.WinsValue = 1.0;
                _rockPaperScissorsModel.LosesValue = 1.0;
            }
            if (diffinput == 'h')
            {
                _rockPaperScissorsModel.WinsValue = 0.5;
                _rockPaperScissorsModel.LosesValue = 1.5;
            }
        }
    }
}
