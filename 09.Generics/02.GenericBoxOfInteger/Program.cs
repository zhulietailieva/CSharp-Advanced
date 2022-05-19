using System;

namespace _02.GenericBoxOfInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<int> box1 = new Box<int>();
            int inputLines = int.Parse(Console.ReadLine());
            for (int i = 0; i < inputLines; i++)
            {
                box1.AddItem(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine(box1.ToString());
        }
    }
}
