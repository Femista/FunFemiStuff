using System;
using System.Collections.Generic;

namespace Composite
{
    public class CompoundGraphic : IGraphic
    {
        private readonly List<IGraphic> _graphicChildren = new List<IGraphic>();

        public void Add(IGraphic graphicChild)
        {
            _graphicChildren.Add(graphicChild);
        }

        public void Remove(IGraphic graphicChild)
        {
            _graphicChildren.Remove(graphicChild);
        }
        public void Move(int x, int y)
        {
            foreach (var graphicChild in _graphicChildren)
            {
                graphicChild.Move(x, y);
            }
        }

        public void Draw()
        {
            foreach (var graphicChild in _graphicChildren)
            {
                graphicChild.Draw();
            }
        }
    }
}