using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Dp.With_Dp
{
    internal abstract class Duck
    {

        // we need to make a contruct for a fly behavior to define the fly 
        // composition is way better  than inheritance (not all time ) class duck has a IflyBehavoir
        // we develop agasist a (abstraction) interface not a concert class 
        public IFlyBehaviour FlyBehaviour { get; set; }// if we make a type if fly nofly or a normalspeed the code will be titylcapule on a that class
        // thos we develop agaist interface noy conecr class we make a code a lossleeycoupled 
        // we make a ctor not to creat a object but we make to to chaion and defined a flybehaviour

        public IQuackBehaviour QuackBehaviour { get; set; } // the same thing in quackbehavir
        public Duck(IFlyBehaviour flyBehaviour, IQuackBehaviour quackBehaviour) // in this step we know or accept the flybehaviour throe chnain 
        {
            FlyBehaviour = flyBehaviour;// normalspeed   // nofly
            QuackBehaviour = quackBehaviour; // normalsqula  //squeeeking  

        }
        // delegation
        // yhis fun accept the fly behaviour and  action or perform it 
        public void Fly(Action flyBehaviour)
        {
           // FlyBehaviour.PerformFly();
           flyBehaviour();
        }
        public void Quack()
        {
            QuackBehaviour.PerformQuack();
        }
        public void Swim()
            => Console.WriteLine("I am Swimming");
        public abstract void Display();
    }
}
