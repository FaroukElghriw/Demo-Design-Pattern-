using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsractFactory_Dp.GearBox
{
    internal interface IGearBox
    {
        public int ShiftNumber { get;  }
        public bool IsAutomatic { get;  }
    }
}
