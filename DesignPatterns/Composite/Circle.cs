using System;

namespace Composite
{
    public class Circle : Dot
    {
        private readonly double _radius;
        public Circle(int x, int y, double radius) : base(x, y)
        {
            _radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing dot at X: {X} and Y: {Y} with radius: {_radius}");
        }
    }
}