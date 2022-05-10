using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string[] inpData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Car car = new Car(inpData[0], double.Parse(inpData[1]), double.Parse(inpData[2]));
                cars.Add(car);
            }
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] inpData = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = inpData[1];
                double distance = double.Parse(inpData[2]);

                foreach (var car in cars)
                {
                    if (car.Model == model)
                    {
                        car.Drive(distance);
                    }
                }
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
