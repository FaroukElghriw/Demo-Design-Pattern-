using AbsractFactory_Dp.Engine;
using AbsractFactory_Dp.Frontwing;
using AbsractFactory_Dp.GearBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsractFactory_Dp.Factories
{
    internal class ConcreteFactoru01 : IFactory
    {
        public IEngine GetEngine()
                          => new BmwEngine();

        public IFrontwing GetFrontwing()
                               => new DesignB();
        public IGearBox GetGearBox()
                               => new GearBoxX();
    }
}
