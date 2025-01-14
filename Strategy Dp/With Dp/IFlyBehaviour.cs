using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Strategy_Dp.With_Dp
{
    // we have 2 relationship between classes => {inheritance  is a and agggeation has a  ={assoction not must and composition must}}
    // this is the condtrut basend on it we defined the form of the fly
     interface IFlyBehaviour
    {
        void PerformFly();// based on fly behaviour  we can make a fly
        // we make a in the interface a one method for achbvie single reponsibily
    }
    class NoFly : IFlyBehaviour
    {
        public void PerformFly()
           => Console.WriteLine("No Wings to Fly :( ");
    }
    class NormalSpeedFly : IFlyBehaviour
    {
        public void PerformFly()
           => Console.WriteLine("Fly with NormalSpeed");
    }
    // my code is open for exstation we can add a new Behaviour
    class RokectSpeed : IFlyBehaviour
    {
        public void PerformFly()
           => Console.WriteLine("Iam fly with  RocketSpeed O_O");
    }
}
