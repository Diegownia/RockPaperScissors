using System;
using System.Collections.Generic;
using System.Text;

namespace Games.Data.Core
{
    public class RockPaperScissorsDeepLogic : IRockPaperScissorsDeepLogic
    {
        public event EventHandler<OutcomeEventArgs> OutcomeEvent = delegate { };

        public void MoveCompare(Moves pcMove, Moves playerMove)
        {
            switch (pcMove, playerMove)
            {
                case (Moves.Rock, Moves.Paper):
                case (Moves.Paper, Moves.Scissors):
                case (Moves.Scissors, Moves.Rock):
                    OutcomeEvent.Invoke(this, new OutcomeEventArgs(Outcomes.Win));
                    break;

                case (Moves.Paper, Moves.Rock):
                case (Moves.Scissors, Moves.Paper):
                case (Moves.Rock, Moves.Scissors):
                    OutcomeEvent.Invoke(this, new OutcomeEventArgs(Outcomes.Lose));
                    break;
                default:
                    OutcomeEvent.Invoke(this, new OutcomeEventArgs(Outcomes.Draw));
                    break;

            }
        }


    }
}
