using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var compoundGraphic1 = new CompoundGraphic();
            compoundGraphic1.Add(new Dot(5, 20));
            compoundGraphic1.Add(new Circle(1, 3, 15));
            var compoundGraphic2 = new CompoundGraphic();
            compoundGraphic2.Add(new Circle(1, 1, 2));
            compoundGraphic2.Add(new Dot(3, 3));
            compoundGraphic2.Add(compoundGraphic1);
            compoundGraphic2.Draw();
            compoundGraphic2.Move(30, 100);
            compoundGraphic2.Draw();
            Console.ReadLine();
        }
    }
}
