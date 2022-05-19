using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.GenericSwapMethodInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box<int>> list = new List<Box<int>>();
            int numOfBoxes = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfBoxes; i++)
            {

                list.Add(new Box<int>(int.Parse(Console.ReadLine())));
            }
            int[] swapData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            Swap<Box<int>>(list, swapData[0], swapData[1]);
            foreach (var item in list)
            {
                Console.Write(item.ToString());
            }

        }
        public static void Swap<T>(List<T> items, int firstIndex, int secondIndex)
        {
            T temp = items[firstIndex];
            items[firstIndex] = items[secondIndex];
            items[secondIndex] = temp;
        }
    }
}
