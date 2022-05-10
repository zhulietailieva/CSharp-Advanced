using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        string make;
        string model;
        int year;
        decimal fuelQuantity;
        decimal fuelConsumption;
        Engine engine;
        Tire[] tires = new Tire[4];

        public Car()
        {
            this.make = "VW";
            this.model = "Golf";
            this.year = 2025;
            this.fuelQuantity = 200;
            this.fuelConsumption = 10;
        }
        public Car(string make,string model,int year) :this()
        {
            this.make = make;
            this.model = model;
            this.year = year;

        }

        public Car(string make,string model,int year, decimal fuelQuantity, decimal fuelConsumption) : this(make,model,year)
        {
            this.fuelConsumption = fuelConsumption;
            this.fuelQuantity = fuelQuantity;
        }
        public Car(string make, string model, int year, decimal fuelQuantity, decimal fuelConsumption,Engine engine,
            Tire[] tires): this(make,model,year,fuelQuantity,fuelConsumption)
        {
            this.engine = engine;
            this.tires = tires;
        }


        public string Make { get { return this.make; } set { this.make = value; } }
        public string Model { get { return this.model; } set { this.model = value; } }
        public int Year { get { return this.year; } set { this.year = value; } }
        public decimal FuelQuantity  { get{ return this.fuelQuantity ; } set{this.fuelQuantity=value ; } }
        public decimal FuelConsumption { get { return fuelConsumption; } set { this.fuelConsumption = value; } }
        
        public Engine Engine { get { return this.engine; } set { this.engine = value; } }
        public void Drive(decimal distance)
        {
            if (fuelQuantity - (fuelConsumption * distance) > 0)
            {
                fuelQuantity -= (fuelConsumption * distance);
            }
            else
            {
              //  Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }
        public string WhoAmI()
        {
            return $@"Make: {this.Make}
 Model: {this.Model}
 Year: {this.Year}
 Fuel: {this.FuelQuantity:F2}";
        }
        public double GetSumTiresPressure()
        {
            double totalSum = 0;
            for (int i = 0; i < tires.Length; i++)
            {
                totalSum += tires[i].Pressure;
            }
            return totalSum;
        }
    }
}
