using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSLn
{
	internal class Refree
	{
        public string Name { get; set; }


		public override string ToString()
			  => $"Refree:{Name}";
		public void Look()
			=> Console.WriteLine($"{this} Is Looking");
	}
}
