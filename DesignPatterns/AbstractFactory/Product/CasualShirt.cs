using System;

namespace AbstractFactory.Product
{
    public class CasualShirt : IShirt
    {
        private readonly int _buttons;

        public CasualShirt(bool buttonUp)
        {
            if (buttonUp)
            {
                _buttons = 3;
            }
        }

        public void Wear()
        {
            Console.WriteLine("Wearin my shirt...casually....with " + _buttons + " buttons.");
        }
    }
}