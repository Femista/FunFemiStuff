using System;

namespace Adapter.Client
{
    internal class PlasticToyDuck : IToyDuck
    {
        public void squeak()
        {
            Console.WriteLine("Squeak");
        }
    }
}