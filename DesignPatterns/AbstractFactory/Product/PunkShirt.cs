using System;

namespace AbstractFactory.Product
{
    public class PunkShirt : IShirt
    {
        private readonly int _buttons;

        public PunkShirt(bool buttonUp)
        {
            if (buttonUp)
            {
                _buttons = 10;
            }
        }

        public void Wear()
        {
            Console.WriteLine("Wearin my punk ass shirt with " + _buttons + " buttons.");
        }
    }
}