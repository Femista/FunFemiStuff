using System;

namespace AbstractFactory.Product
{
    public class ChicShirt : IShirt
    {
        private readonly int _buttons;

        public ChicShirt(bool buttonUp)
        {
            if (buttonUp)
            {
                _buttons = 2;
            }
        }

        public void Wear()
        {
            Console.WriteLine("Wearin my cute ass shirt with " + _buttons + " buttons.");
        }
    }
}