using System;
using System.Collections.Generic;

namespace _13.CountSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();
          SortedDictionary<char,int> chars=new SortedDictionary<char,int>();
         for(int i = 0; i < input.Length; i++)
            {
                if (!chars.ContainsKey(input[i]))
                {
                    chars.Add(input[i],1);
                }
                else
                {
                    chars[input[i]]++;
                }
            }
            foreach (var ch in chars)
            {
                Console.WriteLine($"{ch.Key}: {ch.Value} time/s");
            }
        }
    }
}
