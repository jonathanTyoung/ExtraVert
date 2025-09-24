// Models/Tree.cs
using System;

namespace ExtraVert.Models
{
    public class Tree : Plant
    {
        // Additional properties specific to trees
        public double HeightInFeet { get; set; }
        public bool IsDeciduous { get; set; }
        public string BarkType { get; set; }

        // Constructor
        public Tree(string name, string species, string lightNeeds, string waterNeeds,
                        decimal price, double heightInFeet, bool isDeciduous, string barkType)
            : base(name, species, lightNeeds, waterNeeds, price)
        {
            HeightInFeet = heightInFeet;
            IsDeciduous = isDeciduous;
            BarkType = barkType;
        }

        // Override the DisplayInfo method to include tree-specific information
        public override void DisplayInfo()
        {
            // Call the base class DisplayInfo method
            base.DisplayInfo();

            // Add tree-specific information
            Console.WriteLine($"Height: {HeightInFeet} feet");
            Console.WriteLine($"Deciduous: {(IsDeciduous ? "Yes" : "No")}");
            Console.WriteLine($"Bark Type: {BarkType}");
        }

        // Override the GetPlantType method
        public override string GetPlantType()
        {
            return "Tree Plant";
        }

        // Add a method specific to trees
        public void Prune()
        {
            Console.WriteLine($"Pruning {Name} to maintain its shape and health.");
        }
    }
}