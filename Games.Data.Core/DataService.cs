using System;
using System.Collections.Generic;
using System.Text;

namespace Games.Data.Core
{
    public class DataService : IDataService
    {
        private IRockPaperScissorsModel _rockPaperScissorsModel;
        private IRockPaperScissorsDeepLogic _rockPaperScissorsDeepLogic;
        public DataService(IRockPaperScissorsModel rockPaperScissorsModel,
            IRockPaperScissorsDeepLogic rockPaperScissorsDeepLogic)
        {
            _rockPaperScissorsModel = rockPaperScissorsModel;
            _rockPaperScissorsDeepLogic = rockPaperScissorsDeepLogic;
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

        public void PickInterpreter(string selection)
        {
            Random pcMove = new Random();
            switch (selection)
            {
                case "r":
                    _rockPaperScissorsDeepLogic.MoveCompare((Moves)pcMove.Next(3), Moves.Rock);
                    break;
                case "p":
                    _rockPaperScissorsDeepLogic.MoveCompare((Moves)pcMove.Next(3), Moves.Paper);
                    break;
                case "s":
                    _rockPaperScissorsDeepLogic.MoveCompare((Moves)pcMove.Next(3), Moves.Scissors);
                    break;
            }
        }
    }
}
