using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.FindEvensOrOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputData = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int start = inputData[0];
            int end = inputData[1];
            Predicate<int> isOdd = IsNumberOdd;
            string criteria = Console.ReadLine();
            List<int> res = new List<int>();
            if (criteria == "odd")
            {
                for (int i = start; i <= end; i++)
                {
                    if (isOdd(i))
                    {
                        res.Add(i);
                    }
                }
            }
            else if (criteria == "even")
            {
                for (int i = start; i <= end; i++)
                {
                    if (!isOdd(i))
                    {
                        res.Add(i);
                    }
                }
            }
            Console.WriteLine(String.Join(" ",res));
            
            

        }
        public static bool IsNumberOdd(int n)
        {
            if(n%2!=0)
            {
                return true;
            }
            return false;
        }
        
       
    }
}
