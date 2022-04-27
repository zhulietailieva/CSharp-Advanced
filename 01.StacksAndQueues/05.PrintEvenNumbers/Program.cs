using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _05.PrintEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] input=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> queue=new Queue<int>();
            foreach (var n in input)
            {
                if (n % 2 == 0)
                {
                    queue.Enqueue(n);
                }
            }
            while(queue.Count > 1)
            {
                Console.Write(queue.Dequeue()+", ");
            }
            Console.WriteLine(queue.Dequeue());
        }
    }
}
