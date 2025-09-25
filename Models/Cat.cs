// Models/Cat.cs
using System;

namespace ExtraVert.Models
{
    public class Cat : ISoundMaker
    {
        public string Name { get; set; }
        public string Color { get; set; }

        // Property from ISoundMaker interface
        public string SoundDescription { get; private set; }

        // Constructor
        public Cat(string name, string color)
        {
            Name = name;
            Color = color;
            SoundDescription = "Meow! Meow!";
        }

        // Implement ISoundMaker.MakeSound method
        public void MakeSound()
        {
            Console.WriteLine($"{Name} says: {SoundDescription}");
        }

        // Cat-specific method
        public void Climb()
        {
            Console.WriteLine($"{Name} is climbing the tree!");
        }
    }
}