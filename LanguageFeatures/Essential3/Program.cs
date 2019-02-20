using System;
using Essential3.Models;

namespace Essential3
{
    class Program
    {
        // * Not an ideal approach * lambda is preferable
        // for being sent to 'Filter' extension method
        public static bool IsOriginTehranMethod(Flight f)
        {
            return (f?.From ?? "<No Where") == "Tehran";
        }
        // * Not an ideal approach * lambda is preferable
        // for being sent to 'Filter' extension method
        static Func<Flight, bool> IsOriginTehranDelegate1 = delegate (Flight f)
        {
            return (f?.From ?? "<No Where>") == "Tehran";
        };
        static Func<Flight, bool> IsOriginTehranDelegate2 = (Flight f) => (f?.From ?? "<No Where>") == "Tehran";
        static void Main(string[] args)
        {
            Airport a = new Airport {
                Flights = new Flight[]
                {
                    new Flight(100) { From = "Tehran", To = "Mashhad", Date = DateTime.Parse("2019/08/08") },
                    new Flight(30) { From = "Tehran", To = "Yazd", Date = DateTime.Parse("2019/09/08") },
                    new Flight(40) { From = "Tehran", To = "Tabriz", Date = DateTime.Parse("2019/10/08") },
                    new Flight(80) { From = "Kish", To = "Tehran", Date = DateTime.Parse("2019/11/08") }
                }
            };
            
            Console.WriteLine($"Total Passengers: {a.TotalPassengers()}");
            Console.WriteLine($"Total Passengers (Destinamtion[0] == 'T'): {a.FilterByDestination('T').TotalPassengers()}");
            Console.WriteLine($"Total Passengers (Origin == \"Tehran\") using lambda: {a.Filter(f => (f?.From ?? "<No Where>") == "Tehran").TotalPassengers()}");

            // below approaches are not ideal
            Console.WriteLine($"Total Passengers (Origin == \"Tehran\") using method: {a.Filter(IsOriginTehranMethod).TotalPassengers()}");
            Console.WriteLine($"Total Passengers (Origin == \"Tehran\") using func: {a.Filter(IsOriginTehranDelegate1).TotalPassengers()}");
            Console.WriteLine($"Total Passengers (Origin == \"Tehran\") using func: {a.Filter(IsOriginTehranDelegate2).TotalPassengers()}");
        }
    }
}
