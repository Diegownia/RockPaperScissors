namespace Games.Data.Core
{
    public interface IScoreCalculator
    {

        void CountScore(int wins, int loses);
    }
}