using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Dp.With_No_Dp
{
    internal class RubberDuck : Duck
    {
        public override void Display()
          => Console.WriteLine("I am RubberDuck *_*");
        public new void Quack()
        {
            Console.WriteLine("I am Squeeking");
            Console.Beep(49, 5000);
        }
        public new void Fly()
            => Console.WriteLine("No Wings to FLy :(");
    }
}
