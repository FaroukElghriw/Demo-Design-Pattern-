namespace Decorator_DP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Espresso espresso = new Espresso();
            //Console.WriteLine(espresso);
            Espresso doubleEspresso=new Espresso(espresso);
            Console.WriteLine(doubleEspresso);
            //Milk espressoWithMilk=new Milk(espresso); // is a bevrage and we make a rapping for the espresso to be a esspres with Milk
            //// we dont need to creat a class espressowithmik and achvue this trow composition and inhirtacbe we make it in runtiome
            //Console.WriteLine(espressoWithMilk);
            //Mocha espressoWithMilkandMocha = new Mocha(espressoWithMilk) ;
            //Console.WriteLine( espressoWithMilkandMocha);
        }
    }
}