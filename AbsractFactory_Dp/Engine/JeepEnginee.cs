using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsractFactory_Dp.Engine
{
    internal class JeepEnginee : IEngine
    {
        public int Hourspower => 2500;

        public int Maxspeed => 190;
    }
}
