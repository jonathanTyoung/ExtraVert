// Models/SucculentPlant.cs
using System;

namespace ExtraVert.Models
{
    public class SucculentPlant : Plant
    {
        // Additional properties specific to succulent plants
        public bool IsIndoor { get; set; }
        public string WaterStorageOrgan { get; set; }
        public bool IsToxicToPets { get; set; }

        // Constructor
        public SucculentPlant(string name, string species, string lightNeeds, string waterNeeds,
                             decimal price, bool isIndoor, string waterStorageOrgan, bool isToxicToPets)
            : base(name, species, lightNeeds, waterNeeds, price)
        {
            IsIndoor = isIndoor;
            WaterStorageOrgan = waterStorageOrgan;
            IsToxicToPets = isToxicToPets;
        }

        // Override the DisplayInfo method to include succulent plant specific information
        public override void DisplayInfo()
        {
            // Call the base class DisplayInfo method
            base.DisplayInfo();

            // Add succulent plant specific information
            Console.WriteLine($"Indoor: {(IsIndoor ? "Yes" : "No")}");
            Console.WriteLine($"Water Storage Organ: {WaterStorageOrgan}");
            Console.WriteLine($"Toxic to Pets: {(IsToxicToPets ? "Yes" : "No")}");
        }

        // Override the GetPlantType method
        public override string GetPlantType()
        {
            return "Succulent Plant";
        }

        // Override the Water method for succulents
        public override void Water()
        {
            Console.WriteLine($"Watering {Name} sparingly - succulents need less water than other plants.");
        }

        // Add a method specific to succulent plants
        public void Propagate()
        {
            Console.WriteLine($"Propagating {Name} by taking a leaf or stem cutting.");
        }
    }
}