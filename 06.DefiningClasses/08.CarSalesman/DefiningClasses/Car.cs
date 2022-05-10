using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    internal class Car
    {
        public Car(string model,Engine engine)
        {
            this.Model = model;
            this.CarEngine = engine;
            this.Weight = "n/a";
            this.Color = "n/a";
        }
        public Car(string model, Engine engine,int weight):this(model,engine)
        {
            this.Weight = weight+"";
        }
        public Car(string model,Engine engine,string color): this(model, engine)
        {
            this.Color = color;
        }
        public Car(string model,Engine engine,int weight,string color) : this(model, engine, weight)
        {
            this.Color = color;
        }
        public string Model { get; set; }
        public Engine CarEngine { get; set; }

        //optionals
        public string Weight { get; set; }
        public string  Color { get; set; }
    }
}
