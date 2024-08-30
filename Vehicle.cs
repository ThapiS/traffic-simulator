using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone2_Project
{
 
        // Abstract base class for all vehicles
        public abstract class Vehicle
        {
            // Properties to hold vehicle ID, speed, and direction
            public string Id { get; set; }
            public double Speed { get; set; }
            public string Direction { get; set; }

            // Constructor to initialize vehicle properties
            public Vehicle(string id, double speed, string direction)
            {
                Id = id;
                Speed = speed;
                Direction = direction;
            }

            // Abstract method for movement, to be implemented by derived classes
            public abstract void Move();
        }

        // Derived class representing a car
        public class Car : Vehicle
        {
            // Constructor to initialize car-specific properties
            public Car(string id, double speed, string direction) : base(id, speed, direction) { }

            // Implementation of the Move method for cars
            public override void Move()
            {
                Console.WriteLine($"Car {Id} is moving at speed {Speed} towards {Direction}.");
            }
        }

        // Derived class representing a truck
        public class Truck : Vehicle
        {
            // Constructor to initialize truck-specific properties
            public Truck(string id, double speed, string direction) : base(id, speed, direction) { }

            // Implementation of the Move method for trucks
            public override void Move()
            {
                Console.WriteLine($"Truck {Id} is moving at speed {Speed} towards {Direction}.");
            }
        }

    }

