using System;

namespace Games.Data.Core
{
    public interface IGameManager
    {
        void SetDifficulty(char diffinput);
        void PickInterpreter(string selection);
        int GetIntergerFromUserInput();
        void RoundSetter(int numberofrounds);
        char DiceThrower();
        char DiceScoreCounter();
        ConsoleKeyInfo GetEnterFromUser();
    }
}