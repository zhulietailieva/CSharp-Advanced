using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Engine
    {
        int horsePower;
        double cubicCapacity;

        public Engine(int horsePower,double cubicCapacity)
        {
            this.horsePower = horsePower;
            this.cubicCapacity = cubicCapacity;
        }
        public int HorsePower { get { return this.horsePower; } set { horsePower = value; } }
        public double CubicCapacity { get { return this.cubicCapacity; } set { cubicCapacity = value; } }


    }
}
