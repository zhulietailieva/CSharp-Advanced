using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.MaximumAndMinimumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Stack<int> stack=new Stack<int>();
            for (int i = 0; i < N; i++)
            {
                int[] data=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int command = data[0];
                if (command == 1)
                {
                    int x = data[1];
                    stack.Push(x);
                }
                else if (command == 2)
                {
                    stack.Pop();

                }
                else if(command == 3)
                {
                    if(stack.Count > 0)
                    {
                        Console.WriteLine(stack.Max());
                    }

                }
                else if (command == 4)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
            }
            Console.WriteLine(String.Join(", ",stack));
        }
    }
}
