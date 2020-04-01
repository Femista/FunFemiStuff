using System;
using Observer.Publisher;

namespace Observer.Subscriber
{
    public class SubscriberB : ISubscriber
    {
        public void Update(IPublisher publisher)
        {
            if (((Publisher.Publisher) publisher).State == 0 || ((Publisher.Publisher) publisher).State >= 2)
            {
                Console.WriteLine("ConcreteObserverB: Reacted to the event.");
            }
        }
    }
}