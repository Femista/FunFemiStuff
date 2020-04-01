using System;

namespace Adapter.Service
{
    internal class Sparrow : IBird
    {
        // a concrete implementation of bird 
        public void fly()
        {
            Console.WriteLine("Flying");
        }

        public void makeSound()
        {
            Console.WriteLine("Chirp Chirp");
        }
    }
}