using System;
using System.Linq;

namespace _03.CountUppercaseWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            words = words.Where(word => (int)word[0] > 64 && (int)word[0] < 91).ToArray();
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
