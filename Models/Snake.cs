// Models/Snake.cs
using System;

namespace ExtraVert.Models
{
    public class Snake
    {
        public string Name { get; set; }
        public string Color { get; set; }

        // Constructor
        public Snake(string name, string color)
        {
            Name = name;
            Color = color;
        }

        // Snake-specific method
        public void Slither()
        {
            Console.WriteLine($"{Name} is slithering through the brush!");
        }
    }
}