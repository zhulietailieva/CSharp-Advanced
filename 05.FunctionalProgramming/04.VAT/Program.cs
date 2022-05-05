using System;
using System.Linq;

namespace _04.VAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] values = Console.ReadLine().Split(", ").Select(double.Parse).ToArray();
            values = values.Select(x => x * 1.2).ToArray();
            foreach (var value in values)
            {
                Console.WriteLine($"{value:f2}");
            }
        }
    }
}
