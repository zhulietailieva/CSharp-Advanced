using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Tire
    {
        int year;
        double pressure;
        public Tire(int year,double pressure)
        {
            this.year = year;
            this.pressure = pressure;

        }
        public double Pressure { get { return this.pressure; }  }
    }
}
