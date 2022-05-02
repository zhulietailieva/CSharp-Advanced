using System;
using System.Collections.Generic;

namespace _09.UniqueUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            HashSet<string> names=new HashSet<string>();
            for (int i = 0; i < N; i++)
            {
                names.Add(Console.ReadLine());
            }
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
