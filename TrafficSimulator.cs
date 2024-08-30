using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone2_Project
{
    internal class TrafficSimulator
    {
        // List to hold all the vehicles in the simulation
        private List<Vehicle> vehicles;

        // List to hold all the traffic lights in the simulation
        private List<TrafficLight> trafficLights;
        private int v;

        // Constructor to initialize the simulator
        public TrafficSimulator()
        {


        }

        public TrafficSimulator(List<Vehicle> vehicles, List<TrafficLight> trafficLights)
        {
            this.vehicles = vehicles;
            this.trafficLights = trafficLights;
        }

        public TrafficSimulator(int v)
        {
            this.v = v;
        }

        // Method to add a vehicle to the simulation
        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        // Method to add a traffic light to the simulation
        public void AddTrafficLight(TrafficLight trafficLight)
        {
            trafficLight = new TrafficLight("Red",10);
            trafficLights = new List<TrafficLight>();
            trafficLights.Add(trafficLight);
        }

        // Method to start the simulation
        public void StartSimulation()
        {
            // Simulate traffic light changes
            foreach (var light in trafficLights)
            {
                // Simulate traffic light color changes over time
                light.ChangeColor("Green");
                System.Threading.Thread.Sleep(light.Duration * 500); // Wait for the duration of the light
                light.ChangeColor("Yellow");
                System.Threading.Thread.Sleep(1000); // Yellow light for 2 seconds
                light.ChangeColor("Red");
                System.Threading.Thread.Sleep(light.Duration * 500); // Wait for the duration of the light

                // Simulate vehicle movements
                vehicles = new List<Vehicle>();
                foreach (var vehicle in vehicles)
                {
                    vehicle.Move();
                }

            }
        }

        internal void AddRoad(Road road1)
        {
           
            road1 = new Road("Lenchen Avenue");
            List<Road> list = new List<Road>();
            list.Add(road1);           

        }

        internal void AddIntersection(Intersection intersection)
        {
            //throw new NotImplementedException();
        }

        internal void AddVehicle(Vehicle truck1, Vehicle car1)
        {
            
        }

        
    }
}
