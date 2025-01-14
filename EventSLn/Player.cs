using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace EventSLn
{
	internal class Player
	{
        public string Name { get; set; }
        public string Team { get; set; }

		public override string ToString()
			 => $"Player:{Name} , Team: {Team}";

		public void Run()
			=> Console.WriteLine($"{this} is Running");
	}
}
