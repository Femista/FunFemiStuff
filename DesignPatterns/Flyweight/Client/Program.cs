using System;

namespace Flyweight.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var forest = new Forest();
            forest.PlantTree(1, 3, "Birch", "Brown", "Hard");
            forest.PlantTree(2, 7, "Birch", "Brown", "Hard");
            forest.PlantTree(5, 10, "Birch", "Brown", "Hard");
            forest.PlantTree(3, 40, "Oak", "Orange", "Itchy");
            forest.PlantTree(8, 210, "Pine", "Green", "Soft");
            forest.PlantTree(8, 210, "Pine", "Green", "Soft");
            forest.PlantTree(8, 210, "Uhhh", "Blue", "Whatever");
            forest.Draw("The Femi Canvas");
            Console.ReadLine();
        }
    }
}
