using System;

namespace AbstractFactory.Product
{
    public class ChicPants : IPants
    {
        public void wear()
        {
            Console.WriteLine("Wearin my cute pants");
        }
    }
}