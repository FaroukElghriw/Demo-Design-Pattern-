using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsractFactory_Dp.Engine
{
    internal class BmwEngine : IEngine
    {
        public int Hourspower => 2200;

        public int Maxspeed => 180;
    }
}
