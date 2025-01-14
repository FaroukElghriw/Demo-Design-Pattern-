using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_DP
{
    // Abstract Compomnet
   abstract class Beverage
    {
        public virtual decimal Cost { get; set; }
        public virtual string Description { get; set; }

        public override string ToString()
          => $"{Description} \nCost={Cost:c}";
    }
    // bassci COmmponet
     class Espresso : Beverage
    {
        Beverage _beverage;
        public Espresso(Beverage beverage)// we make a decorator 
        {
            _beverage = beverage;
            Cost = _beverage.Cost + 2.5M;
            Description = $"{_beverage.Description} with Espresso";
        }
        public Espresso() // basic compoonet
        {
            Cost = 2.5M;
            Description = "Espresso Coffee";
        }
    }
    class HouseBlend:Beverage
    {
        public HouseBlend()
        {
            Cost = 3.5M;
            Description = "HouseBlend";
        }


    }
    class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Cost = 2.5M;
            Description = "DarkRoast";
        }
    }
    class DeCafe : Beverage
    {
        public DeCafe()
        {
            Cost = 4.5M;
            Description = "DeCaFe";
        }
    }
}
