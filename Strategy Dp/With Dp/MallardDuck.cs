using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Dp.With_Dp
{
    internal class MallardDuck : Duck
    {
        public MallardDuck():base(new NormalSpeedFly(), new NormalQuack())
        {
            
        }
        public override void Display()
        {
            Console.WriteLine("Iam MallaedDuck :) ");
        }
    }
}
