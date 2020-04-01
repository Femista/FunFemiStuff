using System;
using Strategy.Context;
using Strategy.Strategy;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var navigator = new Navigator();
            navigator.SetStrategy(new WalkStrategy());
            Console.WriteLine(navigator.GetArrivalTime("Mcdonalds", 5));
            navigator.SetStrategy(new MetroStrategy());
            Console.WriteLine(navigator.GetArrivalTime("Mcdonalds", 5));
            navigator.SetStrategy(new DriveStrategy());
            Console.WriteLine(navigator.GetArrivalTime("Mcdonalds", 5));
            Console.ReadLine();
        }
    }
}
