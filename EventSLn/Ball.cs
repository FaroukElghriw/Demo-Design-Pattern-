using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSLn
{
	internal class Ball
	{
        public int Id { get; set; }
		private Location ballLocation;

		public Location BallLocation
		{
			get => ballLocation; 
			set { 
				if(ballLocation != value) // ball movedto anthor loac
				{
					ballLocation = value;
					BallLocationChanged?.Invoke();// to fire the event 

				}
			
			}
		}
		public event Action BallLocationChanged;// in the event have a invokaiob list we shoud define the signatrur of the fun will be in it 

	}
}
