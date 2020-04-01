namespace Prototype
{
    public abstract class Shape
    {
        private readonly int _x;
        private readonly int _y;
        private readonly string _color;

        protected Shape(int x, int y, string color)
        {
            _x = x;
            _y = y;
            _color = color;
        }

        protected Shape(Shape source)
        {
            _x = source._x;
            _y = source._y;
            _color = source._color;
        }

        public abstract Shape Clone();
    }
}