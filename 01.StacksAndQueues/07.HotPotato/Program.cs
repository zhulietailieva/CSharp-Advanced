using System;
using System.Collections.Generic;

namespace _07.HotPotato
{
    internal class Program
    {
        static void Main(string[] args)
        {
         string[] children=Console.ReadLine().Split(' ');
            Queue<string> queue=new Queue<string>();
            int n=int.Parse(Console.ReadLine());
            foreach(string child in children)
            {
                queue.Enqueue(child);
            }
            int currToss = 1;

            while(queue.Count > 1)
            {
                if(currToss == n)
                {
                    Console.WriteLine($"Removed { queue.Dequeue()}");     
                    currToss = 1;

                }
                else
                {
                    currToss++;
                   queue.Enqueue(queue.Dequeue());
                }
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
