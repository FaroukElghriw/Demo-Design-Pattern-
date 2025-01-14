using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Strategy_Dp.With_No_Dp
{
    internal abstract class Duck
    {
        public void Swim()
            => Console.WriteLine("I am Swimming");

        public void Quack()
        {
            Console.WriteLine("I am Qucacking");
            Console.Beep();
        }
        public void Fly()
            => Console.WriteLine("I am Flying with  normal sspeed");

        public abstract void Display();
        
    }
}
