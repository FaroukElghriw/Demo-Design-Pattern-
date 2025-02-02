using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Dp
{
    internal class Player : IObserverable
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public Location Location { get ; set ; }

        public void Updadte(Location newLocation)
        {
            Location = newLocation;
            Console.WriteLine($"{this} is Runinng Towards");
        }
        public override string ToString()
              => $"{Name} , {Team}";
    }
}
