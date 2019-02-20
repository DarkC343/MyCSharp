namespace Essential2.Models
{
    public class Cow : ICow
    {
        private decimal? _weight { get; set; }
        public decimal? Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                if(value <= 100)
                {
                    throw new System.Exception("Unbelievable!");
                }
                else _weight = value;
            }
        }

        public decimal? MilkVolume()
        {
            return (decimal) _weight * 100;
        }
    }
}