// Program.cs
using System;
using System.Collections.Generic;
using ExtraVert.Models;
using ExtraVert.Services;

namespace ExtraVert
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create some animals
            Dog fido = new Dog("Fido", "Golden Retriever");
            Cat whiskers = new Cat("Whiskers", "Tabby");
            Snake skinny = new Snake("Skinny", "Copperhead");

            // Use dog-specific method
            fido.Fetch();

            // Use cat-specific method
            whiskers.Climb();

            // Use snake-specific method
            skinny.Slither();

            // Create a list of only animals that make sounds
            List<ISoundMaker> soundMakers = new List<ISoundMaker>
            {
                fido,    // Dog implements ISoundMaker
                whiskers // Cat implements ISoundMaker
            };

            // Create the sound service
            SoundService soundService = new SoundService();

            // Make all sounds
            soundService.MakeAllSounds(soundMakers);

            // Make Fido's sound twice
            soundService.MakeSoundTwice(fido);

            Console.ReadLine();
        }
    }
}







// // Program.cs
// using System;
// using ExtraVert.Data;
// using ExtraVert.Models;
// using ExtraVert.UI;

// namespace ExtraVert
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Initialize our repository and seed it with data
//             PlantRepository plantRepo = new PlantRepository();
//             plantRepo.SeedData();

//             // Create our menu
//             Menu menu = new Menu();

//             bool running = true;
//             while (running)
//             {
//                 Console.Clear();
//                 Console.WriteLine("Welcome to ExtraVert Plant Nursery Management System!");
//                 Console.WriteLine("------------------------------------------------");
//                 Console.WriteLine();

//                 menu.ShowMainMenu();
//                 int choice = menu.GetMenuChoice();

//                 switch (choice)
//                 {
//                     case 1: // View All Plants
//                         Console.Clear();
//                         Console.WriteLine("All Plants:");
//                         Console.WriteLine("----------");
//                         foreach (Plant plant in plantRepo.GetAllPlants())
//                         {
//                             Console.WriteLine($"Plant Type: {plant.GetPlantType()}");
//                             plant.DisplayInfo();
//                             Console.WriteLine();
//                         }
//                         Console.WriteLine("Press any key to continue...");
//                         Console.ReadKey();
//                         break;

//                     case 2: // Add a New Plant
//                         Console.WriteLine("This feature will be implemented in a future chapter.");
//                         Console.WriteLine("Press any key to continue...");
//                         Console.ReadKey();
//                         break;

//                     case 3: // Search for Plants
//                         Console.Clear();
//                         Console.Write("Enter search term: ");
//                         string searchTerm = Console.ReadLine();

//                         var searchResults = plantRepo.SearchPlants(searchTerm);

//                         Console.WriteLine($"\nSearch Results for '{searchTerm}':");
//                         Console.WriteLine("-------------------------");

//                         if (searchResults.Count == 0)
//                         {
//                             Console.WriteLine("No plants found matching your search term.");
//                         }
//                         else
//                         {
//                             foreach (Plant plant in searchResults)
//                             {
//                                 Console.WriteLine($"Plant Type: {plant.GetPlantType()}");
//                                 plant.DisplayInfo();
//                                 Console.WriteLine();
//                             }
//                         }

//                         Console.WriteLine("Press any key to continue...");
//                         Console.ReadKey();
//                         break;

//                     case 4: // Exit
//                         running = false;
//                         break;

//                     default:
//                         Console.WriteLine("Invalid choice. Please try again.");
//                         Console.WriteLine("Press any key to continue...");
//                         Console.ReadKey();
//                         break;
//                 }
//             }

//             Console.WriteLine("Thank you for using ExtraVert Plant Nursery Management System!");
//             Console.WriteLine("Press any key to exit...");
//             Console.ReadKey();
//         }
//     }
// }