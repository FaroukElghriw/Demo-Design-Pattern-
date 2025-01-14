using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_DP
{
    abstract class Decorator:Beverage
    {
        protected Beverage _beverage;
        public Decorator(Beverage beverage)
        {

            _beverage = beverage;

        }
    }
    class Milk:Decorator
    {
        // milkn has a beverage and milk with beverage is a beverage (2 relationship inheritance and composition)
     //   Beverage _beverage;// composition
        public Milk(Beverage beverage):base(beverage) // we need we someone create a object from a milk must sednd a bervage with added milk to it
        {
         
           
        }
        public override string Description => $"{_beverage.Description} With Milk";
        public override decimal Cost => _beverage.Cost + 1.5M;

    }
    class Mocha : Decorator
    {
        //Beverage _beverage;
        public Mocha(Beverage beverage):base(beverage) 
        {
        
        }

        public override string Description => $"{_beverage.Description} With Mocha";
        public override decimal Cost => _beverage.Cost + 2.5M;
    }

}
