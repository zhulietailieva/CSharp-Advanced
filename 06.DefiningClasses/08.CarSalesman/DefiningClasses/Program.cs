using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>(); 

            int numOfEngines = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfEngines; i++)
            {
                string[] inpData = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
                string model = inpData[0];
                int power = int.Parse(inpData[1]);
                if (inpData.Length > 2)
                {
                    
                    
                    if (inpData.Length > 3)
                    {
                        int displacement = int.Parse(inpData[2]);
                        string efficency = inpData[3];
                        //has all 4 elements
                        engines.Add(new Engine(model,power,displacement,efficency));
                        continue;
                    }
                       //has 3 elements
                    //may be efficeny instead of displacement
                    if (char.IsLetter(inpData[2][0]))
                        {
                        string efficeny = inpData[2];
                        engines.Add(new Engine(model, power, efficeny));
                         }
                    else
                    {
                        int displacement =int.Parse( inpData[2]);
                        engines.Add(new Engine(model, power, displacement));
                    }
                    
                    
                    
                    continue;
                }
                //has only 2 elements
                engines.Add(new Engine(model, power));
            }
            int MCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < MCars; i++)
            {
                string[] inpData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = inpData[0];
                string engineModel = inpData[1];
                if (inpData.Length > 2)
                {
                   
                    if (inpData.Length > 3)
                    {
                        int weight = int.Parse(inpData[2]);
                        string color = inpData[3];
                        //ctors
                        foreach (var engine in engines)
                        {
                            if (engine.Model.Equals(engineModel))
                            {
                                //all 4 elements
                                cars.Add(new Car(model, engine, weight, color));
                                break;
                            }
                        }
                        continue;
                    }
                    //3 elements                  
                    //may be color instead of weight
                    if (char.IsLetter(inpData[2][0]))
                    {
                        string color = inpData[2];
                        foreach (var engine  in engines)
                        {
                            if (engine.Model.Equals(engineModel))
                            {
                            cars.Add(new Car(model, engine, color));
                            break;
                            }
                        }

                    }
                    else
                    {
                        int weight = int.Parse(inpData[2]);
                        foreach (var engine in engines)
                        {
                            if (engine.Model.Equals(engineModel))
                            {
                                cars.Add(new Car(model, engine, weight));
                                break;
                            }
                        }
                    }
                    
                    
                    continue;
                }
                //only 2 elemets
                foreach (var engine in engines)
                {
                    if (engine.Model.Equals(engineModel))
                    {
                        cars.Add(new Car(model, engine));
                        break;
                    }
                }
            }
            foreach (var car in cars)
            {
                Console.WriteLine($@"{car.Model}:
  {car.CarEngine.Model}:
    Power: {car.CarEngine.Power}
    Displacement: {car.CarEngine.Displacement}
    Efficiency: {car.CarEngine.Efficency}
  Weight: {car.Weight}
  Color: {car.Color}");

            }
        }
    }
}
