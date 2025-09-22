// Models/HerbPlant.cs
using System;

namespace ExtraVert.Models
{
    public class HerbPlant : Plant
    {
        // Additional properties specific to foliage plants
        public string LeafColor { get; set; }
        public bool IsVariegated { get; set; }
        public string LeafShape { get; set; }

        // Constructor
        public HerbPlant(string name, string species, string lightNeeds, string waterNeeds,
                           decimal price, string leafColor, bool isVariegated, string leafShape)
            : base(name, species, lightNeeds, waterNeeds, price)
        {
            LeafColor = leafColor;
            IsVariegated = isVariegated;
            LeafShape = leafShape;
        }

        // Override the DisplayInfo method to include foliage plant specific information
        public override void DisplayInfo()
        {
            // Call the base class DisplayInfo method
            base.DisplayInfo();

            // Add foliage plant specific information
            Console.WriteLine($"Leaf Color: {LeafColor}");
            Console.WriteLine($"Variegated: {(IsVariegated ? "Yes" : "No")}");
            Console.WriteLine($"Leaf Shape: {LeafShape}");
        }

        // Override the GetPlantType method
        public override string GetPlantType()
        {
            return "Foliage Plant";
        }

        // Add a method specific to foliage plants
        public void Prune()
        {
            Console.WriteLine($"Pruning {Name} to maintain its shape and encourage bushier growth.");
        }
    }
}