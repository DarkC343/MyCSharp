namespace Essential2.Models
{
    public class Icecream
    {
        public Icecream(bool isFavourite = false)
        {
            IsFavourite = isFavourite;
        }
        public string Taste { get; set; } = "Vanilla";
        public decimal? Price { get; set; }
        public bool IsFavourite { get; set; }
    }
}