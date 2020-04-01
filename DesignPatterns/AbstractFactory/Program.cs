using System;
using AbstractFactory.Factory;

namespace AbstractFactory
{
    internal static class Program
    {
        private static IClothesFactory _factory;

        private static void Initialize(string choice)
        {
            switch (choice)
            {
                case "1":
                    _factory = new CasualClothesFactory();
                    break;
                case "2":
                    _factory = new ChicClothesFactory();
                    break;
                default:
                    _factory = new PunkClothesFactory();
                    break;
            }
        }

        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter 1 for Casual, 2 for Chic, 3 for Punk");
                Initialize(Console.ReadLine());
                var pants = _factory.CreatePants();
                var shirt = _factory.CreateShirt(true);
                pants.wear();
                shirt.Wear();
                shirt = _factory.CreateShirt(false);
                shirt.Wear();
            }
        }
    }
}
