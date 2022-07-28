namespace Games.Data.Core
{
    public interface IRockPaperScissorsModel
    {
        int Draws { get; set; }
        int Loses { get; set; }
        double LosesValue { get; set; }
        double Score { get; set; }
        int Wins { get; set; }
        double WinsValue { get; set; }
    }
}