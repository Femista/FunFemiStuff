using System;

namespace Mediator.Component
{
    public class Engine : BaseComponent
    {
        public void Drive()
        {
            Console.WriteLine("Vroom Vroom");
            _mediator.Notify(this, "Drive");
        }

        public void Stop()
        {
            Console.WriteLine("Stopped");
            _mediator.Notify(this, "Stop");
        }
    }
}