using System.Collections.Generic;
using Visitor.Component;
using Visitor.Visitor;

namespace Visitor
{
    public static class Client
    {
        // The client code can run visitor operations over any set of elements
        // without figuring out their concrete classes. The accept operation
        // directs a call to the appropriate operation in the visitor object.
        public static void ClientCode(IEnumerable<IComponent> components, IVisitor visitor)
        {
            foreach (var component in components)
            {
                component.Accept(visitor);
            }
        }
    }
}