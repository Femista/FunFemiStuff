using System;
using Builder.Builder;

namespace Builder
{
    static class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var carBuilder = new CarBuilder();
            var carManualBuilder = new CarManualBuilder();
            director.MakeSportsCar(carBuilder);
            var car = carBuilder.GetResult();
            director.MakeSuv(carManualBuilder);
            var carManual = carManualBuilder.GetResult();
            Console.WriteLine(car.Info);
            Console.WriteLine(carManual.Info);
            Console.ReadLine();
        }
    }
}
