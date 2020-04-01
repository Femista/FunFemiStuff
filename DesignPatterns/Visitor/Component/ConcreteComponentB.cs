using Visitor.Visitor;

namespace Visitor.Component
{
    public class ConcreteComponentB : IComponent
    {
        // Same here: VisitConcreteComponentB => ConcreteComponentB
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public string SpecialMethodOfConcreteComponentB()
        {
            return "B";
        }
    }
}