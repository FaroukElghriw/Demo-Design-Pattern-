using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Dp.With_Dp
{
    internal class RubberDuck : Duck
    {
        public RubberDuck():base(new NoFly(),new Squeeking())
        {
            
        }
        public override void Display()
          =>Console.WriteLine("Iam a RubberDuck *_*");
       
    }
}
