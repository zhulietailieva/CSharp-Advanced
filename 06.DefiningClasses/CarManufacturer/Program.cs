using System;
using System.Collections.Generic;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire[]> tires = new List<Tire[]>();
            string input;
            while((input= Console.ReadLine()) != "No more tires")
            {
                string[] inptData = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Tire first = new Tire(int.Parse(inptData[0]), double.Parse(inptData[1]));
                Tire second = new Tire(int.Parse(inptData[2]), double.Parse(inptData[3]));
                Tire third = new Tire(int.Parse(inptData[4]), double.Parse(inptData[5]));
                Tire fourth = new Tire(int.Parse(inptData[6]), double.Parse(inptData[7]));
                tires.Add(new Tire[] { first, second, third, fourth });
            }

            List<Engine> engines = new List<Engine>();
            while ((input = Console.ReadLine()) != "Engines done")
            {
                string[] inptData = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                engines.Add(new Engine(int.Parse(inptData[0]), double.Parse(inptData[1])));
            }

            List<Car> cars = new List<Car>();

            

            while ((input = Console.ReadLine()) != "Show special")
            {
                string[] inptData = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string make = inptData[0];
                string model = inptData[1];
                int year = int.Parse(inptData[2]);
                decimal fuelQuantity = decimal.Parse(inptData[3]);
                decimal fuelConsumtion = decimal.Parse(inptData[4]);
                int engineIndex = int.Parse(inptData[5]);
                int tiresIndex = int.Parse(inptData[6]);
                Car newCar = new Car(make, model, year, fuelQuantity, fuelConsumtion, engines[engineIndex],tires[tiresIndex]);
                cars.Add(newCar);
            }
            List<Car> specialCars = new List<Car>();

            foreach (var car in cars)
            {
               
                if (car.Year >= 2017&&car.Engine.HorsePower>330&&car.GetSumTiresPressure()>=9&&car.GetSumTiresPressure()<=10)
                {
                    car.Drive(20);
                    specialCars.Add(car);
                }
            }
            foreach (var specialCar in specialCars)
            {
                Console.WriteLine($"Make: {specialCar.Make}");
                Console.WriteLine($"Model: {specialCar.Model}");
                Console.WriteLine($"Year: {specialCar.Year}");
                Console.WriteLine($"HorsePowers: {specialCar.Engine.HorsePower}");
                Console.WriteLine($"FuelQuantity: {specialCar.FuelQuantity}");
            }
        }
    }
}
