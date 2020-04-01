using System;
using System.Collections.Generic;
using Flyweight.Flyweight;

namespace Flyweight.FlyweightFactory
{
    public static class TreeFactory
    {
        private static readonly List<TreeType> TreeTypes = new List<TreeType>();

        public static TreeType GetTreeType(string name, string color, string texture)
        {
            var treeType = TreeTypes.Find(tree => tree.Name == name && tree.Color == color && tree.Texture == texture);
            if (treeType == null)
            {
                Console.WriteLine($"Couldn't find tree of name: {name} color: {color} and texture: {texture}, adding new one");
                treeType = new TreeType(name, color, texture);
                TreeTypes.Add(treeType);
            }

            return treeType;
        }

    }
}