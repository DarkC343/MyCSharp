namespace Essential2.Models
{
    public interface ICow
    {
        decimal? Weight { get; set; }
        decimal? MilkVolume();
    }
}