using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.GenericSwapMethodStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box<String>> list = new List<Box<string>>();
            int numOfBoxes = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfBoxes; i++)
            {
                list.Add(new Box<string>(Console.ReadLine()));
            }
            int[] swapData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            Swap<Box<String>>(list, swapData[0], swapData[1]);
            foreach (var item in list)
            {
                Console.Write(item.ToString());
            }

        }
        public static void Swap<T>(List<T> items,int firstIndex,int secondIndex)
        {
            T temp = items[firstIndex];
            items[firstIndex] = items[secondIndex];
            items[secondIndex] = temp;
        }
    }
}
