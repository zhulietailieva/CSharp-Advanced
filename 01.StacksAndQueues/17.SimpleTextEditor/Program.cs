using System;
using System.Collections.Generic;
using System.Text;

namespace _17.SimpleTextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder text=new StringBuilder(String.Empty);
            Stack<String> changes=new Stack<String>();
            changes.Push(text.ToString());
            for (int i = 0; i < n; i++)
            {
                string[] command=Console.ReadLine().Split(' ');
                if (command[0].Equals("1"))
                {
                    string textToAppend=command[1];
                text=    text.Append(textToAppend);
                    changes.Push(text.ToString());
                }
                else if (command[0].Equals("2"))
                {
                    int count=int.Parse(command[1]);
                    for (int j = 0; j < count; j++)
                    {
                     text   =text.Remove(text.Length - 1,1);
                    }
                    changes.Push(text.ToString());  
                }
                else if (command[0].Equals("3"))
                {
                    int index=int.Parse(command[1]);
                    Console.WriteLine( text.ToString().ToCharArray()[index-1]);
                   
                }
                else if (command[0].Equals("4"))
                {
                    changes.Pop();
                    text.Clear();
                    text.Append(changes.Peek());


                }
            }
        }
    }
}
