using System;
using System.Collections.Generic;
using Visitor.Component;
using Visitor.Visitor;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var components = new List<IComponent>
            {
                new ConcreteComponentA(),
                new ConcreteComponentB()
            };

            Console.WriteLine("The client code works with all visitors via the base Visitor interface:");
            var visitor1 = new ConcreteVisitorA();
            Client.ClientCode(components,visitor1);

            Console.WriteLine();

            Console.WriteLine("It allows the same client code to work with different types of visitors:");
            var visitor2 = new ConcreteVisitorB();
            Client.ClientCode(components, visitor2);
            Console.ReadLine();
        }
    }
}
