using System;

namespace _12.PredicateForNames
{
    internal class Program
    {
        static int n;
        static void Main(string[] args)
        {
            int namesLength = int.Parse(Console.ReadLine());
            n = namesLength;
            string[] names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Predicate<string > isAMatch = IsLessThan;
            foreach (var name in names)
            {
                if (isAMatch(name))
                {
                    Console.WriteLine(name);
                }
            }
        }
        public static bool IsLessThan(string name)
        {
            if (name.Length <= n)
            {
                return true;
            }
            return false;
        }
    }
}
