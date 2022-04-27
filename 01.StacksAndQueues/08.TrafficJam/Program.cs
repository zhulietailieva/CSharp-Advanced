using System;
using System.Collections.Generic;

namespace _08.TrafficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Queue<string> cars=new Queue<string>();
            string command;
            int passedCars = 0;

            while((command = Console.ReadLine()) != "end")
            {
                if (command == "green")
                {
                    if (cars.Count == 0)
                    {
                        break;
                    }
                    for (int i = 0; i < N; i++)
                    {
                        if(cars.Count == 0)
                        {
                            break;
                        }
                        passedCars++;
                       Console.WriteLine($"{cars.Dequeue()} passed!");
                    
                    
                    }
                    
                }
                else
                {
                    cars.Enqueue(command);

                }
            }
            Console.WriteLine($"{passedCars} cars passed the crossroads.");
        }
    }
}
