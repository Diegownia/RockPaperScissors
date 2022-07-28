using System;
using System.Collections.Generic;
using System.Text;

namespace Games.Data.Core
{
    public class OutcomeEventArgs : EventArgs
    {
        public OutcomeEventArgs(Outcomes outcome)
        {
            Outcome = outcome;
        }

        public Outcomes Outcome { get; }

        public string Feedback { get => InterpretedFeedback(); }

        private string InterpretedFeedback()
        {
            switch (Outcome)
            {
                case Outcomes.Win:
                    return "You win";
                case Outcomes.Lose:
                    return "You lost";
                case Outcomes.Draw:
                    return "it's a draw";
            }
            return "unexpected message";
        }
    }
}
