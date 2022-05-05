using System;
using System.Linq;

namespace _01.SortEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            nums = nums.Where(x => x % 2 == 0).ToArray();
            nums = nums.OrderBy(x => x).ToArray();
            Console.WriteLine(String.Join(", ",nums));

        }
    }
}
