using System;
using System.Collections.Generic;

namespace _16.BalancedParenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isBalnaced = true;
            //type 1 (
            //type 2 {
            //type 3 [
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                char currCh = input[i];

                if (currCh == '(')
                {
                    stack.Push(1);
                }
                else if (currCh == '{')
                {
                    stack.Push(2);

                }
                else if (currCh == '[')
                {
                    stack.Push(3);

                }
                else if (currCh == ')')
                {
                    if (stack.Count > 0)
                    {
                        if (stack.Peek() == 1)
                        {
                            stack.Pop();
                        }
                    }
                    else
                    {
                        isBalnaced = false;
                    }

                }
                else if (currCh == '}')
                {
                    if (stack.Count > 0)
                    {
                        if (stack.Peek() == 2)
                        {
                            stack.Pop();

                        }
                    }
                    else
                    {
                        isBalnaced = false;
                    }

                }
                //else if (currCh == ']')
                else
                {
                    if (stack.Count > 0)
                    {
                        if (stack.Peek() == 3)
                        {
                            stack.Pop();

                        }
                    }
                    else
                    {
                        isBalnaced = false;
                    }

                }

            }
            if (stack.Count > 0||(!isBalnaced))
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
