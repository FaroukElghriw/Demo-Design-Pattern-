using AbsractFactory_Dp.Factories;

namespace AbsractFactory_Dp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcreteFactoru01 concreteFactoru01 = new ConcreteFactoru01();
            ConcreteFactory03 con = new ConcreteFactory03();
            F1Car car = new F1Car(con);
            car.Assemble();
        }
    }
}
