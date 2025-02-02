using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Dp
{
    internal class Football
    {
		private Location  location;
		private List<IObserverable> Subscribers;
		
		public Location  Location
		{
			get { return location; }
			set {
				if (!location.Equals(value))
				{
					location= value;
					if (Subscribers is not null)
					{
                        Notify(location); // like fire event

                    }
					
				}
			}
		}
        public Football(Location location)
        {
            Location = location;
			Subscribers = new List<IObserverable>();
        }

		public void Notify(Location newlocation)
		{
			foreach (var subscriber in Subscribers)
				subscriber.Updadte(newlocation);
			
		}
		public void Subscriber(IObserverable subscriber) 
			                    => Subscribers.Add(subscriber);
        public void UnSubscriber(IObserverable subscriber)
                                => Subscribers.Remove(subscriber);


    }
}
