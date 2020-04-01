using System;
using System.Collections.Generic;

namespace Prototype
{
    static class Program
    {
        static void Main(string[] args)
        {
            var shapeList = new List<Shape>();
            var circle = new Circle(1, 3, "Green", 3.2);
            shapeList.Add(circle);
            var circleClone = circle.Clone();
            shapeList.Add(circleClone);
            var rectangle = new Rectangle(1, 3, "Green", 3, 4);
            shapeList.Add(rectangle);
            var rectangleClone = rectangle.Clone();
            shapeList.Add(rectangleClone);
            foreach (var shape in shapeList)
            {
                Console.WriteLine(shape);
            }

            Console.ReadLine();
        }
    }
}
