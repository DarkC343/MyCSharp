using System.Collections;
using System.Collections.Generic;

namespace Essential3.Models
{
    public class Airport : IEnumerable<Flight>
    {
        public IEnumerable<Flight> Flights { get; set; }
        public IEnumerator<Flight> GetEnumerator()
        {
            return Flights.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}