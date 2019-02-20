using System;
using System.Collections.Generic;

namespace Essential3.Models
{
    public static class ExtensionMethods
    {
        public static int TotalPassengers(this IEnumerable<Flight> flights)
        {
            int total = 0;
            foreach(var flight in flights)
            {
                total += flight?.NumberOfPassengers ?? 0;
            }
            return total;
        }
        public static IEnumerable<Flight> FilterByDestination(this IEnumerable<Flight> flights, char firstLetter)
        {
            foreach (var flight in flights)
            {
                if(flight?.To?[0] == firstLetter)
                {
                    yield return flight;
                }
            }
        }
        // extension method: lambda
        public static IEnumerable<Flight> Filter(this IEnumerable<Flight> flights, Func<Flight, bool> selector)
        {
            foreach (var flight in flights)
            {
                if(selector(flight))
                {
                    yield return flight;
                }
            }
        }
    }
}