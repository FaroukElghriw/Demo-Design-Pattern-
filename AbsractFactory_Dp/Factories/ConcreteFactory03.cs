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
    internal class ConcreteFactory03 : IFactory
    {
        public IEngine GetEngine()
                       => new JeepEnginee();

        public IFrontwing GetFrontwing()
                     => new DesignA();
        

        public IGearBox GetGearBox()
                       => new GearBoxY();
    }
}
