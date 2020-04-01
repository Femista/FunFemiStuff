using System.Collections.Generic;
using Flyweight.Context;
using Flyweight.FlyweightFactory;

namespace Flyweight.Client
{
    public class Forest
    {
        private readonly List<Tree> _trees = new List<Tree>();

        public void PlantTree(int x, int y, string name, string color, string texture)
        {
            var treeType = TreeFactory.GetTreeType(name, color, texture);
            var tree = new Tree(treeType, x, y);
            _trees.Add(tree);
        }
        public void Draw(string canvas)
        {
            foreach (var tree in _trees)
            {
                tree.Draw(canvas);
            }
        }
    }
}