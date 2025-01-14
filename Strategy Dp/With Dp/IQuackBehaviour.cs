using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Dp.With_Dp
{
    // this interface we define it to make or contrack the QuackBehavior
   interface IQuackBehaviour
    {
        void PerformQuack();
    }
    class NormalQuack : IQuackBehaviour
    {
        public void PerformQuack()
        {
            Console.WriteLine("Iam Quacking ");
            Console.Beep();
        }
    }
    class Squeeking : IQuackBehaviour
    {
        public void PerformQuack()
        {
            Console.WriteLine("Iam Squeeking");
            Console.Beep(37,2000);
        }
    }
    class AbNormalQuack : IQuackBehaviour
    {
        public void PerformQuack()
        {
            Console.WriteLine("Iam a AbQuack");
            Console.Beep(3434, 5000);
        }
    }
}
