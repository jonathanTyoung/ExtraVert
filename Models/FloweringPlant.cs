// Models/FloweringPlant.cs
using System;

namespace ExtraVert.Models
{
    public class FloweringPlant : Plant
    {
        // Additional properties specific to flowering plants
        public string FlowerColor { get; set; }
        public bool IsAnnual { get; set; }
        public string BloomingSeason { get; set; }

        // Constructor
        public FloweringPlant(string name, string species, string lightNeeds, string waterNeeds,
                             decimal price, string flowerColor, bool isAnnual, string bloomingSeason)
            : base(name, species, lightNeeds, waterNeeds, price)
        {
            FlowerColor = flowerColor;
            IsAnnual = isAnnual;
            BloomingSeason = bloomingSeason;
        }

        // Override the DisplayInfo method to include flowering plant specific information
        public override void DisplayInfo()
        {
            // Call the base class DisplayInfo method
            base.DisplayInfo();

            // Add flowering plant specific information
            Console.WriteLine($"Flower Color: {FlowerColor}");
            Console.WriteLine($"Annual: {(IsAnnual ? "Yes" : "No")}");
            Console.WriteLine($"Blooming Season: {BloomingSeason}");
        }

        // Override the GetPlantType method
        public override string GetPlantType()
        {
            return "Flowering Plant";
        }

        // Add a method specific to flowering plants
        public void Deadhead()
        {
            Console.WriteLine($"Deadheading {Name} to encourage more blooms.");
        }
    }
}