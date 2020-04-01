using System;

namespace AbstractFactory.Product
{
    public class PunkPants : IPants
    {
        public void wear()
        {
            Console.WriteLine("Wearin my badass pants");
        }
    }
}