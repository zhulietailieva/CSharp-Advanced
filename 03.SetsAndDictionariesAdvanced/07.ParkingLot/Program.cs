using System;
using System.Collections.Generic;

namespace _07.ParkingLot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            HashSet<string> cars=new HashSet<string>();
            while((command = Console.ReadLine()) != "END")
            {
                string[] inputData = command.Split(", ",StringSplitOptions.RemoveEmptyEntries);
                string direction=inputData[0];
                if(direction == "IN")
                {
                   cars.Add(inputData[1]);
                }
                else if(direction == "OUT")
                {
                    cars.Remove(inputData[1]);
                }
            }
            if(cars.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
                return;
            }
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
