namespace Mission10_Aguiar.Models
{
    //public interface IBowlingRepository
    //{
    //    IEnumerable<Bowler> Bowlers { get; }
    //}
    public interface IBowlingRepository
    {
        IEnumerable<Bowler> GetBowlersForMarlinsAndSharks();
    }
}
