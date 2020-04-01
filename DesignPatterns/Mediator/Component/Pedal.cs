using System;
using Mediator.Mediator;

namespace Mediator.Component
{
    public class Pedal : BaseComponent
    {
        private bool _canBrake;
        public void Go()
        {
            Console.WriteLine("Pushing Down on Pedal");
            _mediator.Notify(this, "Go");
        }

        public void Brake()
        {
            if (_canBrake)
            {
                Console.WriteLine("Braking");
                _mediator.Notify(this, "Brake");
            }
            else
            {
                Console.WriteLine("Can't break, we're stopped");
            }
        }

        public void AllowBraking(bool canBrake)
        {
            _canBrake = canBrake;
        }
    }
}