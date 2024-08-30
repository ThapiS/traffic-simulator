using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone2_Project
{
    
    
        // Class representing a traffic light
        public class TrafficLight
        {
            // Property to hold the current color of the traffic light
            public string Color { get; private set; }

            // Property to hold the duration of the current light in seconds
            public int Duration { get; set; }

            // Constructor to initialize the traffic light's color and duration
            public TrafficLight(string initialColor, int duration)
            {
                Color = initialColor;
                Duration = duration;
            }

            // Method to change the traffic light's color
            public void ChangeColor(string newColor)
            {
                Color = newColor;
                Console.WriteLine($"Traffic light changed to {Color}.");
            }
        }

    }

