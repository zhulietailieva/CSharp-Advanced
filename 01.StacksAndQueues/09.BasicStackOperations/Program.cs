using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.BasicStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int N=int.Parse(input[0]);
            int S=int.Parse(input[1]);
            int X=int.Parse(input[2]);

           int[] numbers=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < N; i++)
            {
                stack.Push(numbers[i]);
            }
            while (S > 0)
            {
                stack.Pop();
                S--;
            }

            if (stack.Contains(X))
            {
                Console.WriteLine("true");
            }
            else if(stack.Count==0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
