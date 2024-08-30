using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone2_Project
{
    // Class representing a road
    public class Road
    {
        // Property to hold the name or ID of the road
        public string Name { get; set; }

        // List to hold vehicles currently on the road
        public List<Vehicle> Vehicles { get; private set; }

        // Constructor to initialize the road with a name and an empty list of vehicles
        public Road(string name)
        {
            Name = name;
            Vehicles = new List<Vehicle>();
        }

        // Method to add a vehicle to the road
        public void AddVehicle(Vehicle vehicle)
        {
            Vehicles.Add(vehicle);
            Console.WriteLine($"Vehicle {vehicle.Id} added to {Name}.");
        }

        // Method to remove a vehicle from the road
        public void RemoveVehicle(Vehicle vehicle)
        {
            if (Vehicles.Remove(vehicle))
            {
                Console.WriteLine($"Vehicle {vehicle.Id} removed from {Name}.");
            }
            else
            {
                Console.WriteLine($"Vehicle {vehicle.Id} not found on {Name}.");
            }
        }

        // Method to simulate movement of all vehicles on the road
        public void SimulateTraffic()
        {
            foreach (var vehicle in Vehicles)
            {
                vehicle.Move();
            }
        }
    }
}

