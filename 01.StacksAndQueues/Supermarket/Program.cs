using System;
using System.Collections.Generic;

namespace Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> people = new Queue<string>();
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                if (command.Equals("Paid"))
                {
                    while (people.Count > 0)
                    {
                        Console.WriteLine(people.Dequeue());
                    }

                }
                else               
                {
                        people.Enqueue(command);
 
                }
               
            }
            Console.WriteLine($"{people.Count} people remaining.");
        }
    }
}
