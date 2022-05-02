using System;
using System.Collections.Generic;

namespace _12.EvenTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
          Dictionary<int, int> numbers = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (!numbers.ContainsKey(num))
                {
                    numbers.Add(num, 1);
                }
                else
                {
                    numbers[num]++;
                }
            }
            foreach (var N in numbers)
            {
                if (N.Value % 2 == 0)
                {
                    Console.WriteLine(N.Key);
                    return;
                }
            }
        }
    }
}
