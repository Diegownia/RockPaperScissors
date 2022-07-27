namespace RockPaperScissors
{
    public interface IScoreCalculator
    {
        double LosesValue { get; set; }
        double WinsValue { get; set; }

        double CountScore(int wins, int loses);
    }
}