using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Largest3Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> numbers=Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
        numbers=    numbers.OrderByDescending(x => x).ToList();
            if (numbers.Count <= 3)
            {
                Console.WriteLine(String.Join(" ",numbers));
                return;
            }
           int[] biggest3=new int[3] {numbers[0],numbers[1],numbers[2]};
            Console.WriteLine(String.Join(" ",biggest3));

        }
    }
}
