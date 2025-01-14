using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Dp_01
{
    internal class GCard
    {
        public int Data { get; set; }
     private GCard(int data)
       {
            Data= data;
       }
        
        public static readonly GCard SingletonProp = new GCard(123); // same the code of the static method in background
        #region Singleton 01 static method
        // static attribute
        // private static GCard SingletonObj; //  compiler will make the value based on the defualt datatype

        //static GCard()
        //  {
        //      SingletonObj = new GCard(123);
        //  }

        //  // fun will create a objetc
        //  public static GCard GetCard()
        //  {
        //     // if (SingletonObj == null)// this is the frist time to create => we create  // all tie=me check we can modify it 


        //      return SingletonObj;
        //  } 
        #endregion
    }
}
