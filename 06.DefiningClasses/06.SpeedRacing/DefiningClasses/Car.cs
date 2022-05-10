using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        public string Model { get; set; }
       public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public Car(string model,double fuelAmount,double fuelConsumptioPerKm)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptioPerKm;
            TravelledDistance = 0;
        }
        public void Drive(double km)
        {
            if (FuelAmount - (km * FuelConsumptionPerKilometer) >= 0)
            {
                FuelAmount -= (km * FuelConsumptionPerKilometer);
                TravelledDistance += km;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
