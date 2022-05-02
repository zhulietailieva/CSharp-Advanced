using System;
using System.Collections.Generic;

namespace _11.PeriodicTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int inputLines=int.Parse(Console.ReadLine());
            SortedSet<string> elements=new SortedSet<string>();
            for (int i = 0; i < inputLines; i++)
            {
                string[] inputdata = Console.ReadLine().Split(" ", StringSplitOptions.None);
                for (int j = 0; j < inputdata.Length; j++)
                {
                    elements.Add(inputdata[j]);
                }
            }
            Console.WriteLine(String.Join(" ",elements));
        }
    }
}
