using System;
using System.Linq;

namespace _11.ReverseAndExclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            numbers = numbers.Reverse().ToArray();
            numbers = numbers.Where(x => x % n != 0).ToArray();
            Console.WriteLine(String.Join(" ",numbers));
        }
    }
}
