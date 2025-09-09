// UI/Menu.cs
using System;

namespace ExtraVert.UI
{
    public class Menu
    {
        public void ShowMainMenu()
        {
            Console.WriteLine("Main Menu:");
            Console.WriteLine("1. View All Plants");
            Console.WriteLine("2. Add a New Plant");
            Console.WriteLine("3. Search for Plants");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice (1-4): ");
        }

        public int GetMenuChoice()
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int choice))
            {
                return choice;
            }
            return 0; // Invalid choice
        }
    }
}