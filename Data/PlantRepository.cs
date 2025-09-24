// Data/PlantRepository.cs
using System;
using System.Collections.Generic;
using ExtraVert.Models;

namespace ExtraVert.Data
{
    public class PlantRepository
    {
        private List<Plant> _plants = new List<Plant>();

        public List<Plant> GetAllPlants()
        {
            return _plants;
        }

        public void AddPlant(Plant plant)
        {
            _plants.Add(plant);
        }

        public List<Plant> SearchPlants(string searchTerm)
        {
            return _plants.FindAll(p =>
                p.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                p.Species.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                p.GetPlantType().Contains(searchTerm, StringComparison.OrdinalIgnoreCase));
        }

        public void SeedData()
        {
            // Add some sample plants of different types

            // Flowering plants
            _plants.Add(new FloweringPlant(
                "Rose",
                "Rosa",
                "Full sun",
                "Moderate",
                24.99m,
                "Red",
                false,
                "Spring to Fall"));

            _plants.Add(new FloweringPlant(
                "Sunflower",
                "Helianthus annuus",
                "Full sun",
                "Moderate",
                12.99m,
                "Yellow",
                true,
                "Summer"));

            // Foliage plants
            _plants.Add(new FoliagePlant(
                "Monstera",
                "Monstera deliciosa",
                "Bright indirect",
                "Moderate",
                29.99m,
                "Green",
                false,
                "Split"));

            _plants.Add(new FoliagePlant(
                "Pothos",
                "Epipremnum aureum",
                "Low to bright indirect",
                "Low to moderate",
                15.99m,
                "Green and yellow",
                true,
                "Heart-shaped"));

            // Succulent plants
            _plants.Add(new SucculentPlant(
                "Aloe Vera",
                "Aloe barbadensis miller",
                "Bright indirect to full sun",
                "Low",
                18.99m,
                true,
                "Leaves",
                true));

            _plants.Add(new SucculentPlant(
                "Jade Plant",
                "Crassula ovata",
                "Bright indirect to full sun",
                "Low",
                22.99m,
                true,
                "Stems and leaves",
                true));

            _plants.Add(new HerbPlant(
                "Basil",
                "Ocimum basilicum",
                "Full sun to partial shade",
                "Moderate",
                5.99m,
                "Green",
                false,
                "Oval"));
                // Cactus plants
            _plants.Add(new Cactus(
                "Saguaro Cactus",
                "Carnegiea gigantea",
                "Full sun",
                "Very low",
                45.99m,
                true,
                "2-3 inches",
                true));

            // Tree plants
            _plants.Add(new Tree(
                "Japanese Maple",
                "Acer palmatum",
                "Partial shade to full sun",
                "Moderate",
                89.99m,
                8.5,
                true,
                "Smooth, gray-brown"));
        }
    }
}