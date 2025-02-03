using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsractFactory_Dp.GearBox
{
    internal class GearBoxY : IGearBox
    {
        public int ShiftNumber => 7;

        public bool IsAutomatic => true;
    }
}
