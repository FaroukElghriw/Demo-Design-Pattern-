using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsractFactory_Dp.GearBox
{
    internal class GearBoxX : IGearBox
    {
        public int ShiftNumber => 5;

        public bool IsAutomatic => false;
    }
}
