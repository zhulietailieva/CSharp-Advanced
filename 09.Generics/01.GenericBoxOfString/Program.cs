using System;

namespace _01.GenericBoxOfString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<string> box1 = new Box<string>();
            int inputLines =int.Parse( Console.ReadLine());
            for (int i = 0; i < inputLines; i++)
            {
                box1.AddItem(Console.ReadLine());
            }
            Console.WriteLine(box1.ToString());
        }
    }
}
