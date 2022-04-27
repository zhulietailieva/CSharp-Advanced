using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.BasicQueueOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int N = int.Parse(input[0]);
            int S = int.Parse(input[1]);
            int X = int.Parse(input[2]);

            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Queue<int> queue=new Queue<int>();

            for (int i = 0; i < N; i++)
            {
                queue.Enqueue(numbers[i]);
            }
            while (S > 0)
            {
                queue.Dequeue();
                S--;

            }
            if(queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (queue.Contains(X))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
