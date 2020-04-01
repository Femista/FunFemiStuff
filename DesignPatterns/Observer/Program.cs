using System;
using Observer.Subscriber;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            // The client code.
            var subject = new Publisher.Publisher();
            var observerA = new SubscriberA();
            subject.Attach(observerA);

            var observerB = new SubscriberB();
            subject.Attach(observerB);

            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();

            subject.Detach(observerB);

            subject.SomeBusinessLogic();
            Console.ReadLine();
        }
    }
}
