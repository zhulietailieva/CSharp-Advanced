using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        public Car(string model,Engine engine,Cargo cargo,Tire[] tires)
        {
            this.Model = model;
            this.CarEngine = engine;
            this.CarCargo = cargo;
            
            this.Tires = tires;

        }
        public string  Model { get; set; }
        public Engine CarEngine { get; set; }
        public Cargo CarCargo { get; set; }
        public Tire[] Tires { get; set; }

    public bool isPressureOF1TireLessThan1()
        {
            foreach (var tire in Tires)
            {
                if (tire.Pressure < 1)
                {
                    return true;
                }
            }
            return false;
        }    
    }
}
