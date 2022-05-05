using System;
using System.Linq;

namespace _02.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            Console.WriteLine(nums.Length);
            Console.WriteLine(nums.Sum());
     
        }
    }
}
