using System;
using Essential2.Models;

namespace Essential2
{
    class Program
    {


        static void Main(string[] args)
        {
            Store s1 = new Store {
                Mobiles = new Mobile[]
                {
                    new Mobile { Brand = "Apple", Price = 999.9M },
                    new Mobile { Brand = "Samsung", Price = 900M }
                }
            };

            Shop s2 = new Shop {
                Icecreams = new Icecream[]
                {
                    new Icecream { Taste = "Shatuti", Price = 5500M },
                    new Icecream(true) { Taste = "Kakaoee", Price = 4500M }
                }
            };
            Icecream[] myFavIcecreams = new Icecream[]
            {
                new Icecream(true) { Price = 3500M },
                new Icecream(true) { Taste = "Nooshabeii", Price = 3000M }
            };

            Cow c1 = new Cow { Weight = 130 };

            Console.WriteLine($"Total Mobile Prices = {s1.TotalPrices():C2}");
            Console.WriteLine($"Total Shop Icecream Prices = {s2.TotalPrices():C2}");
            Console.WriteLine($"Total Favourite Icecream Prices = {myFavIcecreams.TotalPrices():C2}");
            Console.WriteLine($"Total Favourite Icecream (>= 3200) Prices = {myFavIcecreams.FilterByPrice(3200).TotalPrices():C2}");
            Console.WriteLine($"Total Cow Price = {c1.TotalPrice():C2}");
        }
    }
}
