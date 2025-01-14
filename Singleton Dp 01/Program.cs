namespace Singleton_Dp_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  we nedd to prevebt to create a muliple object from a class=> dln use Singleton Dp 
            #region Singleton Dp
            // this is the frist way to implete the singleton Dp {static method will return a staic attrinut and this ain in static ctor , and make ctor pribvate}
            // 01 => make the ctor private=> so ni onec can create a object from a class
            // 02 => we need to make a static fun and return a object from class 
            // 03 => we  make a privte ststic attribute and the compiler will make the value will dedyal dtatdtey and this static atrr will ctyy the valye of the objct
            // 04 => and make a fun all time return the this static attiute when we crear new instance 
            //04=> for modifiy the fun  we use the static ctor to initil the static attribute that will retued by fun 
            // 02 secon impol => smae the frist step make privare ctor
            // 02 use the static read only prop and make initol of thes
            #endregion
            GCard gCard01 = GCard.SingletonProp;
            GCard gCard02 = GCard.SingletonProp;
            Console.WriteLine(gCard02.GetHashCode());
            Console.WriteLine(gCard01.GetHashCode());

        }
    }
}