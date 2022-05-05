using System;
using System.Linq;

namespace _08.CustomMinFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Func<int[], int> smallestNum = FindSmallest;
          
            Console.WriteLine(smallestNum(numbers); );
        }
        public static int FindSmallest(int[] numbers)
        {
            return numbers.Min();
        }
    }
}
