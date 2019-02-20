using System.Collections.Generic;

namespace Essential2.Models
{
    public static class MyExtensionMethods
    {
        // extension method
        public static decimal TotalPrices(this Store storeParam)
        {
            decimal total = 0;
            foreach (var mobile in storeParam.Mobiles)
            {
                total += mobile?.Price ?? 0;
            }
            return total;
        }
        // apply extension method to a c# standard interface
        public static decimal TotalPrices(this IEnumerable<Icecream> icecreams)
        {
            decimal total = 0;
            foreach (var icecream in icecreams)
            {
                total += icecream?.Price ?? 0;
            }
            return total;
        }
        // apply extension method to a custom interface
        public static decimal TotalPrice(this ICow cow)
        {
            decimal price = 0;
            price += cow?.Weight ?? 0;
            price += cow?.MilkVolume() ?? 0;
            price += 1000M;
            return price;
        }
        // apply filtering extension method to a c# standard interface
        public static IEnumerable<Icecream> FilterByPrice(this IEnumerable<Icecream> icecreams, decimal minimumPrice)
        {
            foreach (var icecream in icecreams)
            {
                if((icecream?.Price ?? 0) >= minimumPrice)
                {
                    yield return icecream;
                }
            }
        }
    }
}