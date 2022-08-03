namespace Games.Data.Core
{
    public interface IGameManager
    {
        void SetDifficulty(char diffinput);
        void PickInterpreter(string selection);
        int GetIntergerFromUserInput();
        int RoundSetter(int numberofrounds);
    }
}