using System;
namespace Games.Data.Core
{
    public interface IRockPaperScissorsDeepLogic
    {
        event EventHandler<OutcomeEventArgs> OutcomeEvent;
        void MoveCompare(Moves pcMove, Moves playerMove);
    }
}