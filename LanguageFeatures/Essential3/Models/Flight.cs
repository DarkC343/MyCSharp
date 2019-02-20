using System;

namespace Essential3.Models
{
    public class Flight
    {
        public Flight(int numberOfPassengers = 0)
        {
            NumberOfPassengers = numberOfPassengers;
        }
        public string From { get; set; }
        public string To { get; set; }
        public int? NumberOfPassengers { get; }
        private DateTime? _date;
        public DateTime? Date
        {
            get
            {
                return _date;
            }
            set
            {
                if((value ?? DateTime.Parse("1900/01/01")) < DateTime.Now)
                {
                    throw new Exception("Expired");
                }
                else _date = value;
            }
        }
    }
}