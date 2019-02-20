using System.Collections;
using System.Collections.Generic;

namespace Essential2.Models
{
    public class Shop : IEnumerable<Icecream>
    {
        public IEnumerable<Icecream> Icecreams { get; set; }
        public IEnumerator<Icecream> GetEnumerator()
        {
            return Icecreams.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}