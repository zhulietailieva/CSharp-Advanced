using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantityFood=int.Parse(Console.ReadLine());
            Queue<int> orders=new Queue<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToArray());
            Console.WriteLine(orders.Max());
            while(orders.Count > 0)
            {
                int currOrder = orders.Peek();
                if (quantityFood - currOrder >= 0)
                {
                    quantityFood -= currOrder;
                    orders.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(' ',orders)}");
                    return;
                }
            }
            Console.WriteLine("Orders complete");

        }
    }
}
