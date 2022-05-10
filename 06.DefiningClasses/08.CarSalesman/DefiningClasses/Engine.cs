using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    internal class Engine
    {
        public Engine(string model,int power)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = "n/a";
            this.Efficency = "n/a";
        }
        public Engine(string model,int power,int displacement) : this(model,power)
        {
            this.Displacement = displacement+"";
        }
        public Engine(string model,int power,string efficency) : this(model, power)
        {
            this.Efficency = efficency;
        }
        public Engine(string model, int power, int displacement,string efficency) : this(model, power,displacement)
        {
            this.Efficency = efficency;
        }
        public string Model { get; set; }
        public int Power { get; set; }
        //optional
        public string  Displacement { get; set; }
        public string  Efficency { get; set; }
    }
}
