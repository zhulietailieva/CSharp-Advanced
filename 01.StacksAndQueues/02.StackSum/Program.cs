using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack=new Stack<int>(input);
            string command;
            while((command = Console.ReadLine()).ToLower() != "end")
            {
                string [] inpuutData=command.Split();
                if (inpuutData[0].ToLower() == "add")
                {
                    stack.Push(int.Parse(inpuutData[1]));
                    stack.Push(int.Parse(inpuutData[2]));
                }
                else if (inpuutData[0].ToLower() == "remove")
                {
                    int count=int.Parse(inpuutData[1]);
                    if (count > stack.Count)
                    {
                        continue;
                    }
                    while (count > 0)
                    {
                        stack.Pop();
                        count--;
                    }
                }
            }
            int sum = stack.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
