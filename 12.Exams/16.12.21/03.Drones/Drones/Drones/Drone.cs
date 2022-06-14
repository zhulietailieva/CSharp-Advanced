using System.Text;

namespace Drones
{
    public class Drone
    {
       

        public string Name { get; set; }
        public string Brand { get; set; }
        public int Range { get; set; }
        public bool Available { get; set; }

        public Drone(string name, string brand, int range)
        {
            Name = name;
            Brand = brand;
            Range = range;
            Available = true;
        }
        public void Fly()
        {
            Available = false;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Drone: {Name}");
            sb.AppendLine($"Manufactured by: {Brand}");
            sb.Append($"Range: {Range} kilometers");
            return sb.ToString();
        }

    }
}