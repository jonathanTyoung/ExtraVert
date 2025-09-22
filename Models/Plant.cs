// Models/Plant.cs
using System;

namespace ExtraVert.Models
{
    public class Plant
    {
        // Properties
        public string Name { get; set; }
        public string Species { get; set; }
        public string LightNeeds { get; set; }
        public string WaterNeeds { get; set; }
        public decimal Price { get; set; }
        public DateTime AcquisitionDate { get; set; }

        // Constructor
        public Plant(string name, string species, string lightNeeds, string waterNeeds, decimal price)
        {
            Name = name;
            Species = species;
            LightNeeds = lightNeeds;
            WaterNeeds = waterNeeds;
            Price = price;
            AcquisitionDate = DateTime.Now;
        }

        // Methods
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Species: {Species}");
            Console.WriteLine($"Light Needs: {LightNeeds}");
            Console.WriteLine($"Water Needs: {WaterNeeds}");
            Console.WriteLine($"Price: ${Price}");
            Console.WriteLine($"Acquisition Date: {AcquisitionDate.ToShortDateString()}");
        }

        public virtual string GetPlantType()
        {
            return "Generic Plant";
        }

        public virtual void Water()
        {
            Console.WriteLine($"Watering {Name} according to its {WaterNeeds} water needs.");
        }
    }
}