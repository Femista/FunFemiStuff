using System;
using Factory.Creator;

namespace Factory
{
    internal static class Program
    {
        private static Dialog _dialog;

        private static void Initialize()
        {
            Console.WriteLine("Enter 1 for Windows or 2 for Mac");
            var os = Console.ReadLine();
            if (os == "1")
            {
                _dialog = new WindowsDialog();
            }
            else
            {
                _dialog = new MacDialog();
            }
        }

        private static void Main(string[] args)
        {
            Initialize();
            _dialog.Render();
            Console.ReadLine();
        }
    }
}