using Visitor.Visitor;

namespace Visitor.Component
{
    public interface IComponent
    {
        void Accept(IVisitor visitor);
    }
}