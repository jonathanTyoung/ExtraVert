// Models/Plant.cs
using System;

namespace ExtraVert.Models
{
    // Define the custom type
    public class Plant
    {
        // Define the properties that will be on each object of this type
        public string Name { get; set; }
        public string Species { get; set; }
        public string LightNeeds { get; set; }
        public string WaterNeeds { get; set; }
        public decimal Price { get; set; }

        // The constructor (i.e. what happens when a new object is created)
        public Plant(string name, string species, string lightNeeds, string waterNeeds, decimal price)
        {
            Name = name;
            Species = species;
            LightNeeds = lightNeeds;
            WaterNeeds = waterNeeds;
            Price = price;
        }

        // A method that is available on every generated object
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Species: {Species}");
            Console.WriteLine($"Light Needs: {LightNeeds}");
            Console.WriteLine($"Water Needs: {WaterNeeds}");
            Console.WriteLine($"Price: ${Price}");
        }
    }
}