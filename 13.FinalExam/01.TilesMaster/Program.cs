using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.TilesMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> whiteTiles = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            Queue<int> greyTiles = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            Dictionary<string, int> locations = new Dictionary<string, int>()
            {
                {"Sink",0 },
                {"Oven",0 },
                {"Countertop",0 },
                {"Wall",0 },
                {"Floor",0 }
            };          

            while (whiteTiles.Count != 0 && greyTiles.Count != 0)
            {
                int currWTile = whiteTiles.Pop();
                int currGTile = greyTiles.Dequeue();

                //if they don't match
                if (currGTile != currWTile)
                {
                    whiteTiles.Push((currWTile / 2));
                    greyTiles.Enqueue(currGTile);
                    continue;
                }
                int currSum = currGTile + currWTile;
                switch (currSum)
                {
                    case 40: locations["Sink"]++; break;
                    case 50: locations["Oven"]++; break;
                    case 60: locations["Countertop"]++; break;
                    case 70: locations["Wall"]++; break;
                    default: locations["Floor"]++; break;
                }
            }
            //print tthe white tiles
            if (whiteTiles.Count == 0)
            {
                Console.WriteLine("White tiles left: none");
            }
            else
            {
                Console.WriteLine($"White tiles left: {string.Join(", ",whiteTiles)}");
            }
            //print the grey tiles
            if (greyTiles.Count == 0)
            {
                Console.WriteLine("Grey tiles left: none");
            }
            else
            {
                Console.WriteLine($"Grey tiles left: {string.Join(", ", greyTiles)}");
            }
            //create a sorted dictionary for the res
            Dictionary<string, int> orderedLocations = new Dictionary<string, int>
                (locations.OrderByDescending(x => x.Value).ThenBy(x => x.Key));
            foreach (var item in orderedLocations)
            {
                if (item.Value > 0)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }

        }
    }
}
