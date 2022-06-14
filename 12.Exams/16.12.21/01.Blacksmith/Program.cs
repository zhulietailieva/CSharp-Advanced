using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01.Blacksmith
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Gladius 70
            //Shamshir    80
            //Katana  90
            //Sabre   110
            //Broadsword  150

            int totalSwords = 0;
            SortedDictionary<string, int> swords = new SortedDictionary<string, int>
            {
                {"Gladius",0 },
                {"Shamshir",0 },
                {"Katana",0 },
                {"Sabre",0 },
                {"Broadsword",0 },

            };
            Queue<int> steel = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> carbon = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            while (steel.Count > 0 && carbon.Count > 0)
            {
                int currSteel = steel.Dequeue();
                int currCarbon = carbon.Pop();

                int sum = currCarbon + currSteel;
                switch (sum)
                {
                    case 70: totalSwords++; swords["Gladius"]++; break;
                    case 80: totalSwords++; swords["Shamshir"]++; break;
                    case 90: totalSwords++; swords["Katana"]++; break;
                    case 110: totalSwords++; swords["Sabre"]++; break;
                    case 150: totalSwords++; swords["Broadsword"]++; break;
                    default: currCarbon += 5; carbon.Push(currCarbon); break;
                }
            }
            //numOfSwords
            if (totalSwords == 0)
            {
                Console.WriteLine("You did not have enough resources to forge a sword.");
            }
            else
            {
                Console.WriteLine($"You have forged {totalSwords} swords.");
            }
            //Steel left
            if (steel.Count == 0)
            {
                Console.WriteLine("Steel left: none");
            }
            else
            {
                Console.WriteLine($"Steel left: {string.Join(", ",steel)}");
            }
            //Carbon left
            if (carbon.Count == 0)
            {
                Console.WriteLine("Carbon left: none");
            }
            else
            {
                Console.WriteLine($"Carbon left: {string.Join(", ",carbon)}");
            }
            //Only the swordes forged
            foreach (var sword in swords)
            {
                if (sword.Value > 0)
                {
                    Console.WriteLine($"{sword.Key}: {sword.Value}");
                }
            }

        }
    }
}
