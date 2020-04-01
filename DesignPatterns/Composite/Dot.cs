using System;

namespace Composite
{
    public class Dot : IGraphic
    {
        protected int X, Y;

        public Dot(int x, int y)
        {
            X = x;
            Y = y;
        }


        public void Move(int x, int y)
        {
            X += x;
            Y += y;
        }

        public virtual void Draw()
        {
            Console.WriteLine($"Drawing dot at X: {X} and Y: {Y}");
        }
    }
}