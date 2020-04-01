using System;
using Visitor.Component;

namespace Visitor.Visitor
{
    class ConcreteVisitorB : IVisitor
    {
        public void Visit(ConcreteComponentA element)
        {
            Console.WriteLine(element.ExclusiveMethodOfConcreteComponentA() + " + ConcreteVisitor2");
        }

        public void Visit(ConcreteComponentB element)
        {
            Console.WriteLine(element.SpecialMethodOfConcreteComponentB() + " + ConcreteVisitor2");
        }
    }
}