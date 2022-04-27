using System;
using System.Collections.Generic;

namespace _04.MatchingBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expr=Console.ReadLine();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < expr.Length; i++)
            {
                
                
                if (expr.ToCharArray()[i].Equals('('))
                {
                    
                    stack.Push(i);
                    

                }
                else if (expr.ToCharArray()[i].Equals(')'))
                {
                    int endIndex=i+1;
                   int startindex=stack.Pop();
                    string subexpr = expr.Substring(startindex, endIndex - startindex);
                    Console.WriteLine(subexpr);
                }
            }
        }
    }
}
