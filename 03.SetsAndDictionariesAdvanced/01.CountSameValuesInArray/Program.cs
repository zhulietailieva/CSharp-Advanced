using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountSameValuesInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] values=Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Dictionary<double,int> occurrences=new Dictionary<double,int>();
            for (int i = 0; i < values.Length; i++)
            {
                if (!occurrences.ContainsKey(values[i]))
                {
                    occurrences.Add(values[i], 1);
                }
                else
                {
                    occurrences[values[i]]++;
                }
            }
            foreach (var item in occurrences)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
