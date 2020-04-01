using System;

namespace Factory.Product
{
    public class WindowsButton : IButton
    {
        public void OnClick(string command)
        {
            Console.WriteLine("Windows Click doing command: " + command);
        }

        public void Render()
        {
            Console.WriteLine("Windows Button Render");
        }
    }
}