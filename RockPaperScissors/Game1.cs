using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    public class Game1 : IGame1
    {
        private double _score = 0;
        private int _wins;
        private int _draws;
        private int _loses;
        private readonly IScoreCalculator _scoreCalculator;

        public Game1(IScoreCalculator scoreCalculator)
        {
            _scoreCalculator = scoreCalculator;
        }

        public double Score
        {
            get => _score;
            set
            {
                _score = _scoreCalculator.CountScore(_wins, _loses);
            }
        }

        public int 
    }

    enum Moves
    {
        Rock = 0,
        Paper = 1,
        Scissors = 2
    }
}
