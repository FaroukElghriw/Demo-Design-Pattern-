using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsractFactory_Dp.Engine
{
    internal interface IEngine
    {
        public int Hourspower { get;  }
        public int Maxspeed { get; }
    }
}
