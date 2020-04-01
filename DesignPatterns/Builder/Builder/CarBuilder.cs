using System;
using System.Collections.Generic;
using System.Text;
using Builder.Product;

namespace Builder.Builder
{
    class CarBuilder : IVehicleBuilder
    {
        private Car _car;

        public void Reset()
        {
            _car = new Car();
        }

        public void SetSeats(int seatNumber)
        {
            _car.Seats = seatNumber;
        }

        public void SetEngine(string engineType)
        {
            _car.Engine = engineType;
        }

        public void SetColor(string color)
        {
            _car.Color = color;
        }

        public void SetInfo(string name)
        {
            _car.Info = $"I am a {_car.Color} car created by {name} with {_car.Seats} seats.";
        }

        public Car GetResult()
        {
            return _car;
        }
    }
}
