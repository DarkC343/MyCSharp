using System;

namespace LanguageFeatures.Models
{
    public class Gadget
    {
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public Gadget Related { get; set; }
        public Gadget[] GetAllGadgets()
        {
            // object initializer: is a way of fullfilling the object using { ... } rather than making a 'new' and then call and assign all it's properties
            var g1 = new Gadget { Name = "Mobile", Price = 300.2M, ReleaseDate = DateTime.Parse("1995/01/01"), Related = null };
            var g2 = new Gadget { Name = "Smart Phone", Price = 600.4M, ReleaseDate = DateTime.Parse("2000/01/01"), Related = g1 };
            var g3 = new Gadget { Name = "Tablet", Price = 900.6M, ReleaseDate = DateTime.Parse("2005/01/01"), Related = g2 };
            // collection initializer
            return new Gadget[] { g1, null, g2, g3 };
        }
    }
}