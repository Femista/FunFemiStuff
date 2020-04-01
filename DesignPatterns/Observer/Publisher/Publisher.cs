using System;
using System.Collections.Generic;
using System.Threading;
using Observer.Subscriber;

namespace Observer.Publisher
{
    public class Publisher : IPublisher
    {
        // For the sake of simplicity, the Subject's state, essential to all
        // subscribers, is stored in this variable.
        public int State { get; set; }

        // List of subscribers. In real life, the list of subscribers can be
        // stored more comprehensively (categorized by event type, etc.).
        private readonly List<ISubscriber> _subscribers = new List<ISubscriber>();

        // The subscription management methods.
        public void Attach(ISubscriber subscriber)
        {
            Console.WriteLine("Subject: Attached a subscriber.");
            _subscribers.Add(subscriber);
        }

        public void Detach(ISubscriber observer)
        {
            _subscribers.Remove(observer);
            Console.WriteLine("Subject: Detached an observer.");
        }

        // Trigger an update in each subscriber.
        public void Notify()
        {
            Console.WriteLine("Subject: Notifying observers...");

            foreach (var subscriber in _subscribers)
            {
                subscriber.Update(this);
            }
        }

        // Usually, the subscription logic is only a fraction of what a Subject
        // can really do. Subjects commonly hold some important business logic,
        // that triggers a notification method whenever something important is
        // about to happen (or after it).
        public void SomeBusinessLogic()
        {
            Console.WriteLine("\nSubject: I'm doing something important.");
            State = new Random().Next(0, 10);

            Thread.Sleep(15);

            Console.WriteLine("Subject: My state has just changed to: " + State);
            Notify();
        }
    }
}