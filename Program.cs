using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Milestone2_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a traffic simulator with a simulation time of 10 units
            TrafficSimulator simulator = new TrafficSimulator(10);

            // Create some roads
            Road road1 = new Road("Main Street");
            Road road2 = new Road("2nd Avenue");

            // Create some vehicles
            Vehicle car1 = new Car("Car001", 60, "North");
            Vehicle truck1 = new Truck("Truck001", 40, "East");

            // Add vehicles to roads
            road1.AddVehicle(car1);
            road2.AddVehicle(truck1);

            // Create a traffic light and intersection
            TrafficLight light = new TrafficLight("Red", 30);
            Intersection intersection = new Intersection("Main Intersection", light);

            // Add roads to intersection
            //intersection.AddRoad(road1);
            //intersection.AddRoad(road2);

            // Add roads and intersections to the simulator
            simulator.AddRoad(road1);
            simulator.AddRoad(road2);
            simulator.AddTrafficLight(light);
            simulator.AddIntersection(intersection);
            simulator.AddVehicle(truck1, car1);
            simulator.StartSimulation();

            // Run the simulation
            //object value = simulator.Run();
            Console.ReadLine();
            
        }
    }
}
