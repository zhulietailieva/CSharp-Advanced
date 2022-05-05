using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.KnightsOfHonor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList<string>();
            Action<List<string>> printKnights = PrintKnights;
           printKnights(names);

            
           
        }
        public static void PrintKnights(List<string> names)
        {
            //don't change the initial List
            List<string> namesCopy = new List<string>(names);
            
            if (namesCopy.Count == 0)
            {
                return;
            }
           
            Console.WriteLine($"Sir {namesCopy[0]}");
            namesCopy.RemoveAt(0);
             PrintKnights(namesCopy);
            
        }
    }
}
