using System;
using Flyweight.Flyweight;

namespace Flyweight.Context
{
    public class Tree
    {
        private readonly int _x, _y;
        private readonly TreeType _treeType;

        public Tree(TreeType treeType, int x, int y)
        {
            _treeType = treeType;
            _x = x;
            _y = y;
        }

        public void Draw(string canvas)
        {
            _treeType.Draw(canvas, _x, _y);
        }
    }
}