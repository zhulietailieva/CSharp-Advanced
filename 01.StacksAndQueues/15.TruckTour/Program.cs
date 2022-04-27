using System;
using System.Collections.Generic;
using System.Linq;

namespace _15.TruckTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            
            Queue<int[] > petrolData = new Queue<int[]>();
            
            for (int i = 0; i < N; i++)
            {
                int[] data = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                petrolData.Enqueue(data);
            }


            int startIndex = 0;
           
            while (true)
            { 
                int totalLiters = 0;
                bool isComplete = true;
                foreach (int[] data in petrolData)
                {
                    int liters = data[0];
                    int distance = data[1];
                    totalLiters += liters;
                    if (totalLiters - distance < 0)
                    {
                        isComplete = false;
                        startIndex++;
                        petrolData.Enqueue(petrolData.Dequeue());
                        break;
                    }
                    totalLiters -= distance;
                }
                if (isComplete)
                {
                    Console.WriteLine(startIndex);
                    return;
                }
            }
        }
    }
}
