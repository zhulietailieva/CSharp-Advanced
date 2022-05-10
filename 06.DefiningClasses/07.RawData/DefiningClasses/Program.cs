using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < N; i++)
            {
                string[] inputData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                //"{model} {engineSpeed} {enginePower} {cargoWeight}
                //{cargoType} {tire1Pressure} {tire1Age} {tire2Pressure} {tire2Age} {tire3Pressure} {tire3Age} {tire4Pressure} {tire4Age}"
                string model = inputData[0];
                int engineSpeed = int.Parse(inputData[1]);
                int enginePower = int.Parse(inputData[2]);
                int cargoWeight = int.Parse(inputData[3]);
                string cargoType = inputData[4];
                float tire1Pressure = float.Parse(inputData[5]);
                int tire1Age = int.Parse(inputData[6]);
                float tire2Pressure = float.Parse(inputData[7]);
                int tire2Age = int.Parse(inputData[8]);
                float tire3Pressure = float.Parse(inputData[9]);
                int tire3Age = int.Parse(inputData[10]);
                float tire4Pressure = float.Parse(inputData[11]);
                int tire4Age = int.Parse(inputData[12]);

                Tire[] tires = new Tire[4]
                {
                    new Tire(tire1Age,tire1Pressure),
                    new Tire(tire2Age,tire2Pressure),
                    new Tire(tire3Age,tire3Pressure),
                    new Tire(tire4Age,tire4Pressure)
                };
                Cargo cargo = new Cargo(cargoType, cargoWeight);
                Engine engine = new Engine(engineSpeed, enginePower);
                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }
            string cargoTypeOutput = Console.ReadLine();
            foreach (var car in cars)
            {
                if(cargoTypeOutput== "fragile")
                {
                    if (car.CarCargo.Type == cargoTypeOutput&& car.isPressureOF1TireLessThan1())
                    {

                    Console.WriteLine(car.Model);
                    }
                }   
                    
                
                else if (cargoTypeOutput == "flammable")
                {    
                        
                        if (car.CarCargo.Type == cargoTypeOutput&&car.CarEngine.Power>250)
                        {
                            Console.WriteLine(car.Model);
                        }
                }    
            }
        }
    }
}
