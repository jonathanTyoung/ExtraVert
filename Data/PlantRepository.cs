// Data/PlantRepository.cs
using System;
using System.Collections.Generic;
using ExtraVert.Models;

namespace ExtraVert.Data
{
    public class PlantRepository
    {
        // A collection of plants
        private List<Plant> _plants = new List<Plant>();

        // A method that returns the list of plants
        public List<Plant> GetAllPlants()
        {
            return _plants;
        }

        // A method to add a plant to the private list
        public void AddPlant(Plant plant)
        {
            _plants.Add(plant);
        }

        // A method to insert some starter plants into the list
        public void SeedData()
        {
            // Add some sample plants
            _plants.Add(new Plant("Snake Plant", "Sansevieria trifasciata", "Low to bright indirect", "Low", 15.99m));
            _plants.Add(new Plant("Monstera", "Monstera deliciosa", "Bright indirect", "Moderate", 29.99m));
            _plants.Add(new Plant("Peace Lily", "Spathiphyllum", "Low to bright indirect", "Moderate", 19.99m));
        }
    }
}