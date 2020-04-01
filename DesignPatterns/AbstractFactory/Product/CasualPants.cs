using System;

namespace AbstractFactory.Product
{
    public class CasualPants : IPants
    {
        public void wear()
        {
            Console.WriteLine("Wearin my pants...casually");
        }
    }
}