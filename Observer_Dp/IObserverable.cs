using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Dp
{
    internal interface IObserverable
    {
        public string Name { get; set; }
        public Location Location { get; set; }
        void Updadte(Location newLocation);
    }
}
