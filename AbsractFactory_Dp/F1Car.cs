using AbsractFactory_Dp.Engine;
using AbsractFactory_Dp.Factories;
using AbsractFactory_Dp.Frontwing;
using AbsractFactory_Dp.GearBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsractFactory_Dp
{
    internal class F1Car
    {
        // Composition
        IEngine _engine;
        IGearBox _gearBox;
        IFrontwing _frontwing;
        IFactory _factory;

        public F1Car(IFactory factory)
        {
            _factory = factory;

        }
        public void Assemble()
        {
            _engine = _factory.GetEngine();
            _gearBox = _factory.GetGearBox();
            _frontwing = _factory.GetFrontwing();
        }
    }
}
