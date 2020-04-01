namespace Prototype
{
    public class Circle : Shape
    {
        private readonly double _radius;

        public Circle(int x, int y, string color, double radius) : base(x, y, color)
        {
            _radius = radius;
        }

        private Circle(Circle source) : base(source)
        {
            _radius = source._radius;
        }

        public override Shape Clone()
        {
            return new Circle(this);
        }

        public override string ToString()
        {
            return $"I am a Circle with radius {_radius}";
        }
    }
}