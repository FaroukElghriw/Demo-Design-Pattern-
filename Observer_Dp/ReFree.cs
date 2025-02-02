using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Dp
{
    internal class ReFree : IObserverable
    {
        public string Name { get; set ; }
        public Location Location { get; set ; }

        public void Updadte(Location newLocation)
        {
            Location= newLocation;
            Console.WriteLine($"{this} is looking at loaction {Location}");
        }
        public override string ToString()
             => $"Refree: {Name}";
    }
}
