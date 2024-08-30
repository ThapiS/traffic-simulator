using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone2_Project
{
    
    
        public class Intersection
        {
        private string v;
        private TrafficLight light;

        public List<Road> Roads { get; private set; }
            public List<TrafficLight> TrafficLights { get; private set; }

            public Intersection(List<Road> roads, List<TrafficLight> trafficLights)
            {
                Roads = roads;
                TrafficLights = trafficLights;
            }

        public Intersection(string v, TrafficLight light)
        {
            this.v = v;
            this.light = light;
        }

        //internal void AddRoad(Road road1)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
