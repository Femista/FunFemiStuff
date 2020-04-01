using System;

namespace Flyweight.Flyweight
{
    public class TreeType
    {
        public string Name { get; }
        public string Color { get; }
        public string Texture { get; }

        public TreeType(string name, string color, string texture)
        {
            Name = name;
            Color = color;
            Texture = texture;
        }

        public void Draw(string canvas, int x, int y)
        {
            Console.WriteLine($"Drawing tree with name: {Name}, color: {Color}, texture: {Texture} on canvas: {canvas} at position: {x}, {y}");
        }
    }
}