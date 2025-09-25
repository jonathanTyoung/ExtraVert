using System;
using System.Collections.Concurrent;

namespace ExtraVert.Models
{

    public class Flower : Plant
    {

        public bool HasStems { get; set; }

        public string StemLength { get; set; }

        public bool IsGardenType { get; set; }


        public Flower(string name, string species, string lightNeeds, string waterNeeds,
                        decimal price, bool hasStems, string stemLength, bool isGardenType)
            : base(name, species, lightNeeds, waterNeeds, price)
        {
            HasStems = hasStems;
            StemLength = stemLength;
            IsGardenType = isGardenType;
        }


        public override void DisplayInfo()
        {
            base.DisplayInfo();

            Console.WriteLine($"Has Stems: {(HasStems ? "Yes" : "No")}");
            Console.WriteLine($"Stem length: {StemLength}");
            Console.WriteLine($"Garden Type: {(IsGardenType ? "Yes" : "No")}");
        }

        public override string GetPlantType()
        {
            return "Flower Plant";
        }


        public override void Water()
        {
            Console.WriteLine($"Watering {Name} a ton - flowers need lots of water.");
        }

        public void HandleCarefully()
        {
            Console.WriteLine($"Handling {Name} carefully to avoid spine injuries.");

        }
    }
}