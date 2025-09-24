// Models/Cactus.cs
using System;

namespace ExtraVert.Models
{
    public class Cactus : Plant
    {
        // Additional properties specific to cacti
        public bool HasSpines { get; set; }
        public string SpineLength { get; set; }
        public bool IsDesertType { get; set; }

        // Constructor
        public Cactus(string name, string species, string lightNeeds, string waterNeeds,
                          decimal price, bool hasSpines, string spineLength, bool isDesertType)
            : base(name, species, lightNeeds, waterNeeds, price)
        {
            HasSpines = hasSpines;
            SpineLength = spineLength;
            IsDesertType = isDesertType;
        }

        // Override the DisplayInfo method to include cactus-specific information
        public override void DisplayInfo()
        {
            // Call the base class DisplayInfo method
            base.DisplayInfo();

            // Add cactus-specific information
            Console.WriteLine($"Has Spines: {(HasSpines ? "Yes" : "No")}");
            Console.WriteLine($"Spine Length: {SpineLength}");
            Console.WriteLine($"Desert Type: {(IsDesertType ? "Yes" : "No")}");
        }

        // Override the GetPlantType method
        public override string GetPlantType()
        {
            return "Cactus Plant";
        }

        // Override the Water method for cacti
        public override void Water()
        {
            Console.WriteLine($"Watering {Name} very sparingly - cacti need minimal water.");
        }

        // Add a method specific to cacti
        public void HandleCarefully()
        {
            Console.WriteLine($"Handling {Name} carefully to avoid spine injuries.");
        }
    }
}