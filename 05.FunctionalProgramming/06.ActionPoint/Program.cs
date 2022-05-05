using System;

namespace _06.ActionPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Action<string[]> printOnNewLine = PrintOnNewLine;
            printOnNewLine(names);

        }
        public static void PrintOnNewLine(string[] lines)
        {
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
