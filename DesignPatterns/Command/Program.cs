using System;
using Command.Command;
using Command.Receiver;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var couch = new Product("Couch", 300);

           var couchDecreaseBy100Buton = new Invoker.Invoker();
           couchDecreaseBy100Buton.SetCommand(new ProductCommand(couch, PriceAction.Decrease, 100));
           Console.WriteLine(couch);
           couchDecreaseBy100Buton.Invoke();
           Console.WriteLine(couch);
           couchDecreaseBy100Buton.UndoActions();
           Console.WriteLine(couch);
           Console.ReadLine();
        }
    }
}
