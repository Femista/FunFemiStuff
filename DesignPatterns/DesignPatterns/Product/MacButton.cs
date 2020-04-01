using System;

namespace Factory.Product
{
    internal class MacButton : IButton
    {
        public void OnClick(string command)
        {
            Console.WriteLine("Mac Click doing command: " + command);
        }

        public void Render()
        {
            Console.WriteLine("Mac Button Render");
        }
    }
}