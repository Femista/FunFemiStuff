using System;
using Observer.Publisher;

namespace Observer.Subscriber
{
    public class SubscriberA : ISubscriber
    {
        public void Update(IPublisher publisher)
        {
            if (((Publisher.Publisher) publisher).State < 3)
            {
                Console.WriteLine("ConcreteObserverA: Reacted to the event.");
            }
        }
    }
}