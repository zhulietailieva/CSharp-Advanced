using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SetsOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n = inputData[0];
            int m = inputData[1];
            HashSet<int> setN = new HashSet<int>();
            HashSet<int> setM = new HashSet<int>();
            HashSet<int> finalSet = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                setN.Add(int.Parse(Console.ReadLine()));

            }
            for (int i = 0; i < m; i++)
            {
                setM.Add(int.Parse(Console.ReadLine()));
            }
            foreach (var item in setN)
            {
                if (setM.Contains(item))
                {
                    finalSet.Add(item);
                }
            }
            Console.WriteLine(String.Join(" ",finalSet));
        }
    }
}
