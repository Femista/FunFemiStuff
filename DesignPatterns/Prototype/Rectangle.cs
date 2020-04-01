using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    class Rectangle : Shape
    {
        private readonly int _width;
        private readonly int _height;
        
        public Rectangle(int x, int y, string color, int width, int height) : base(x, y, color)
        {
            _width = width;
            _height = height;
        }

        private Rectangle(Rectangle source) : base(source)
        {
            _width = source._width;
            _height = source._height;
        }

        public override Shape Clone()
        {
            return new Rectangle(this);
        }

        public override string ToString()
        {
            return $"I am a rectangle with width {_width} and height {_height}";
        }
    }
}
