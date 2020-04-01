using System;
using Mediator.Component;
using Mediator.Mediator;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var pedal = new Pedal();
            var engine = new Engine();
            new CarMediator(pedal, engine);
            pedal.Brake();
            pedal.Go();
            pedal.Brake();
            Console.ReadLine();
        }
    }
}
