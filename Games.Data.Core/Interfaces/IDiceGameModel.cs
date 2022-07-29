namespace Games.Data.Core
{
    public interface IDiceGameModel
    {
        int PcScore { get; set; }
        int PlayerScore { get; set; }
        int Rounds { get; set; }
    }
}