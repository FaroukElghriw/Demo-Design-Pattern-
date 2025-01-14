using Strategy_Dp.With_Dp;

namespace Strategy_Dp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           MallardDuck mallardDuck = new MallardDuck();
            mallardDuck.Display();
            mallardDuck.Swim();
            mallardDuck.Quack();
            mallardDuck.Fly(()
                => Console.WriteLine("Fly with NormalSpeed"));

            Console.WriteLine();
            Console.WriteLine("***************************************");

            Console.WriteLine();

            RubberDuck rubberDuck = new RubberDuck();
            rubberDuck.Display();
            rubberDuck.Swim();
            rubberDuck.Quack();
            rubberDuck.Fly(() => Console.WriteLine("No Wings to Fly :( "));

            Console.WriteLine();
            Console.WriteLine("******************Hunting Mode on**********************");
            Console.WriteLine();
            // if we put a patrmater to the fly fun we will not  achvi e the soild prinnble we nedd to a behvaow of the fly to fun fly as a form of the delegate
            // the delegate of the c# in the background becoma a strategy DP 
            // we need to delegate a fly behauot to aanthot thing like delegate
            mallardDuck.FlyBehaviour = new RokectSpeed();
           // mallardDuck.Fly(()
           //=> Console.WriteLine("Iam fly with  RocketSpeed O_O")); // we achive  soild principle and my code be open for wxtension closed for modifaction the fun fly we not mody on it and er can add a behit
                                                                   // the aimm of strategy Dp is chnage behaviour in runtime 
            mallardDuck.Fly(new RokectSpeed().PerformFly);// we can send it object if we use more thna oner time but we use a gose to if we use one time
             
            mallardDuck.QuackBehaviour=new AbNormalQuack();
            mallardDuck.Quack();
            // but in c# we not need to implement the strategy Dp as we have a Delegate
        }
    }
}