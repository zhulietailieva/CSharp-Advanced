using System;
using System.Collections.Generic;

namespace _05.ComparingObjects
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] inpData = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(inpData[0], int.Parse(inpData[1]), inpData[2]);
                list.Add(person);
            }
            int n = (int.Parse(Console.ReadLine())) - 1;
            Person currPerson = list[n];
            int notEqual = 0;
            int matches = 0;
            int totalNum = list.Count;
            foreach(Person person in list)
            {
                if (currPerson.CompareTo(person) == 0)
                {
                    matches++;
                }
                else
                {
                    notEqual++;
                }
            }
            if (matches == 1)
            {
                Console.WriteLine("No matches");
                return;
            }
            Console.WriteLine($"{matches} {notEqual} {totalNum}");
        }
    }
}
