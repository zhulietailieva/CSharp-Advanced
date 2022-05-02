using System;
using System.Collections.Generic;

namespace _08.SoftUniParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
          HashSet<string> vips=new HashSet<string>();
            HashSet<string> regulars=new HashSet<string>();
            string input;
            while ((input = Console.ReadLine()) != "PARTY")
            {

                if (char.IsDigit(input[0]))
                {
                    vips.Add(input);
                }
                else
                {
                    regulars.Add(input);
                }
               
            }
             
            while((input = Console.ReadLine()) !="END")
            { 
                if (char.IsDigit(input[0]))
                {
                    vips.Remove(input);
                }
                else
                {
                    regulars.Remove(input);
                }
            }
           
            Console.WriteLine(vips.Count+regulars.Count);
            foreach (var guest in vips)
            {
                Console.WriteLine(guest);
            }
            foreach (var guest in regulars)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
