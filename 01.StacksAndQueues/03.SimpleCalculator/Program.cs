using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
        string input=Console.ReadLine();
            string[]data=input.Split(" ",StringSplitOptions.RemoveEmptyEntries);
          Stack<int> stack=new Stack<int>();
            stack.Push(int.Parse(data[0]));
            for (int i = 1; i < data.Length; i++)
            {
                
                if (data[i].Equals("+"))
                {
                    int res=int.Parse(data[i+1])+stack.Pop();
                    
                    stack.Push(res);
                }
                else if (data[i].Equals("-"))
                {
                    int res=+stack.Pop()-int.Parse(data[i+1]);
                    stack.Push(res);
                }
            }
            Console.WriteLine( stack.Pop());
           
    }
     }
}
