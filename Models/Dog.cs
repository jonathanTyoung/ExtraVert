// Models/Dog.cs
using System;

namespace ExtraVert.Models
{
    public class Dog : ISoundMaker, IMovable
    {
        public string Name { get; set; }
        public string Breed { get; set; }

        // Property from ISoundMaker interface
        public string SoundDescription { get; private set; }

        // Property from IMovable interface
        public int Speed { get; private set; }

        // Constructor
        public Dog(string name, string breed)
        {
            Name = name;
            Breed = breed;
            SoundDescription = "Woof! Woof!";
            Speed = 15; // mph
        }

        // Implement ISoundMaker.MakeSound method
        public void MakeSound()
        {
            Console.WriteLine($"{Name} says: {SoundDescription}");
        }

        // Implement IMovable.Move method
        public void Move()
        {
            Console.WriteLine($"{Name} is running at {Speed} mph!");
        }

        // Dog-specific method
        public void Fetch()
        {
            Console.WriteLine($"{Name} is fetching the ball!");
        }
    }
}