using System;
using System.Collections.Generic;
using System.Linq;

namespace _13.ListOfPredicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Func<int,int[] ,List<int>> findNums = FindDivisibleNumbers;
            Console.WriteLine(String.Join(" ",findNums(N,dividers)));
        }
        public static List<int> FindDivisibleNumbers(int n,int[] dividers)
        {
            List<int> numbers1ToN = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                numbers1ToN.Add(i);
            }
            List<int> result = new List<int>();
            foreach (var num in numbers1ToN)
            {
                bool isDivisibleToAll = true;
                foreach (var divider in dividers)
                {
                    if (num % divider != 0)
                    {
                        
                        isDivisibleToAll = false;
                        break;
                    }
                }
                if (isDivisibleToAll)
                {
                    result.Add(num);
                }
            }
            return result;
        }
    }
}
