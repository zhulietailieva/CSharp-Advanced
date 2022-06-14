using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drones
{
    public class Airfield
    {
        public List<Drone> Drones { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public double LandingStrip { get; set; }
        public Airfield(string name, int capacity, double landingStrip)
        {
            Drones = new List<Drone>();
            Name = name;
            Capacity = capacity;
            LandingStrip = landingStrip;
        }
        public int Count { get { return Drones.Count; } }
        private List<Drone> drones;
        public string AddDrone(Drone drone)
        {
            if (string.IsNullOrWhiteSpace(drone.Name) || string.IsNullOrWhiteSpace(drone.Brand) || drone.Range < 5 || drone.Range > 15)
            {
                return "Invalid drone.";
            }
            else if (Drones.Count < Capacity)
            {
                Drones.Add(drone);
                return $"Successfully added {drone.Name} to the airfield.";

            }
            else
            {
                return "Airfield is full.";
            }
        }
        public bool RemoveDrone(string name)
        {
            var drone = Drones.Find(d => d.Name == name);
            if (drone != null)
            {
                Drones.Remove(drone);
                return true;
            }
            else
            {
                return false;
            }
        }
        public int RemoveDroneByBrand(string brand)
        {
            int count = Drones.Count;
            Drones.RemoveAll(drone => drone.Brand == brand);
            if (count == Drones.Count)
            {
                return 0;
            }
            else
            {
                return count - Drones.Count;
            }

        }
        public Drone FlyDrone(string name)
        {
            var drone = Drones.Find(d => d.Name == name);
            if (drone != null)
            {
                drone.Fly();
                return drone;
            }
            else
            {
                return null;
            }
        }
        public List<Drone> FlyDronesByRange(int range)
        {
            var drones = new List<Drone>();
            drones = Drones.FindAll(d => d.Range >= range);
            foreach (var drone in drones)
            {
                drone.Fly();
            }
            return drones;
        }
        public string Report()
        {
            var available = Drones.Where((drone) => drone.Available == true).ToList();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Drones available at {Name}:");
            foreach (var drone in available)
            {
                sb.AppendLine(drone.ToString());

            }
            return sb.ToString().TrimEnd();
        }
    }
}