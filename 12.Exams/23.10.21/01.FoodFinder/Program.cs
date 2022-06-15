using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
           char[] vowels = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
           char[] consonants = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse).ToArray();
            Dictionary<string, int> wordsFound = new Dictionary<string, int>()
            {
                {"pear",0 },
                {"flour",0 },
                {"pork",0 },
                {"olive" ,0}
            };
            int count = 0;
            if (consonants.Contains('p') && consonants.Contains('r'))
            {
                if (vowels.Contains('e') && vowels.Contains('a'))
                {
                    count++;
                    wordsFound["pear"]++;
                }

                if (vowels.Contains('o') && consonants.Contains('k'))
                { 
                    wordsFound["pork"]++; 
                    count++; 
                }

            }
            if (consonants.Contains('l') && vowels.Contains('o'))
            {
                if (consonants.Contains('f') && consonants.Contains('r') && vowels.Contains('u'))
                {
                    wordsFound["flour"]++; 
                    count++;
                }


                if (vowels.Contains('i') && vowels.Contains('e') && consonants.Contains('v'))
                {
                    wordsFound["olive"]++; 
                    count++;
                }

            }
            Console.WriteLine($"Words found: {count} ");
            foreach (var word in wordsFound)
            {
                if (word.Value != 0)
                {
                    Console.WriteLine(word.Key);
                }
            }
        }
    }
}
