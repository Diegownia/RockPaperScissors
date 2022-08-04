using System;
using System.Collections.Generic;
using System.Text;

namespace Games.Data.Core
{
    public class GameManager : IGameManager
    {
        private IRockPaperScissorsModel _rockPaperScissorsModel;
        private IRockPaperScissorsDeepLogic _rockPaperScissorsDeepLogic;
        private IScoreCalculator _scoreCalculator;
        private IDiceGameModel _diceGameModel;
        private IDiceSimulator _diceSimulator;

        public GameManager(IRockPaperScissorsModel rockPaperScissorsModel,
            IRockPaperScissorsDeepLogic rockPaperScissorsDeepLogic, 
            IScoreCalculator scoreCalculator, IDiceGameModel diceGameModel,
            IDiceSimulator diceSimulator)
        {
            _rockPaperScissorsModel = rockPaperScissorsModel;
            _rockPaperScissorsDeepLogic = rockPaperScissorsDeepLogic;
            _scoreCalculator = scoreCalculator;
            _diceGameModel = diceGameModel;
            _diceSimulator = diceSimulator;
            _rockPaperScissorsDeepLogic.OutcomeEvent += OnOutcomeEvent;
        }
        //Input interpreters
        public ConsoleKeyInfo GetEnterFromUser()
        {
            
            ConsoleKeyInfo enter = Console.ReadKey();
            while (enter.Key != ConsoleKey.Enter)
            {
                Console.WriteLine("Wrong key pressed...");
                enter = Console.ReadKey();
            }
            return enter;
        }

        public int GetIntergerFromUserInput()
        {
            var pick = Console.ReadLine();
            int input;
            while (!int.TryParse(pick, out input))
            {
                Console.WriteLine("Wrong...");
                pick = Console.ReadLine();
            }
            return input;
        }
        // Game mechanics handlers
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
        public char DiceScoreCounter()
        {
            int player =_diceGameModel.PlayerScore;
            int pc = _diceGameModel.PcScore;
            if (player > pc)
            {
                return 'p';
            }
            else if (player < pc)
            {
                return 'c';
            }
            else if (player == pc)
            {
                return 'd';
            }
            return 'x';
        }
        public void RoundSetter(int numberofrounds)
        {
            _diceGameModel.Rounds = numberofrounds;
        }

        public char DiceThrower()
        {
            return DiceRoundSettler(_diceSimulator.ThrowDice(), _diceSimulator.ThrowDice());

        }
        // private methods
        private char DiceRoundSettler(int playerThrow, int pCThrow)
        {
            if (playerThrow > pCThrow)
            {
                _diceGameModel.PlayerScore++;
                _diceGameModel.Rounds--;
                return 'p';
            }
            else if (playerThrow < pCThrow)
            {
                _diceGameModel.PcScore++;
                _diceGameModel.Rounds--;
                return 'c';
            }
            else if (playerThrow == pCThrow)
            {
                _diceGameModel.Rounds--;
                return 'd';
            }
            return 'x';
        }
        private void OnOutcomeEvent(object sender, OutcomeEventArgs e)
        {
            if (e.Outcome == Outcomes.Win)
            {
                _rockPaperScissorsModel.Wins++;
                _scoreCalculator.CountScore(_rockPaperScissorsModel.Wins,
                    _rockPaperScissorsModel.Loses);
            }
            if (e.Outcome == Outcomes.Lose)
            {
                _rockPaperScissorsModel.Loses++;
                _scoreCalculator.CountScore(_rockPaperScissorsModel.Wins,
                    _rockPaperScissorsModel.Loses);
            }
            if (e.Outcome == Outcomes.Draw)
            {
                _rockPaperScissorsModel.Draws++;
                _scoreCalculator.CountScore(_rockPaperScissorsModel.Wins,
                    _rockPaperScissorsModel.Loses);
            }
        }
    }
}
