using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSLn
{
	internal struct Location
	{
        public int X { get; set; }
		public int Z{ get; set; }
		public int Y { get; set; }
        public Location(int _X,int _Y,int _Z)
        {
            X = _X; 
            Z = _Z;
             Y = _Y;
        }
		public override string ToString()
		         => $"({X} , {Y} , {Z})";
		
		public static bool operator ==(Location left, Location right)
		{
			//return left.X == right.X && left.Z == right.Z && left.Y == right.Y;
			return left.Equals(right) ;
		}
		public static bool operator !=(Location left, Location right)
		{
			//return left.X != right.X || left.Z != right.Z || left.Y != right.Y;
			return !left.Equals(right) ;
		}
	}
}
