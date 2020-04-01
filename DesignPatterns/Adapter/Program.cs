using System;
using Adapter.Client;
using Adapter.Service;

namespace Adapter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var sparrow = new Sparrow();
            var toyDuck = new PlasticToyDuck();

            // Wrap a bird in a birdAdapter so that it  
            // behaves like toy duck 
            var birdAdapter = new BirdAdapter(sparrow);

            Console.WriteLine("Sparrow...");
            sparrow.fly();
            sparrow.makeSound();

            Console.WriteLine("ToyDuck...");
            toyDuck.squeak();

            // toy duck behaving like a bird  
            Console.WriteLine("BirdAdapter...");
            birdAdapter.squeak();

            Console.ReadLine();
        }
    }
}