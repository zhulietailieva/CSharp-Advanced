using System;
using System.Collections.Generic;

namespace _05.FilterByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> peopleData = new Dictionary<string, int>();

            ReadNLines(n, peopleData);
            string olderOrYounger = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            PrintOutput(olderOrYounger, age, data, peopleData);
        }
        public static void ReadNLines(int n,Dictionary<string,int> dic)
        {
            if (n == 0)
            {
                return;
            }
            ReadNLines(n - 1,dic);
            string[] input = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);
            dic.Add(input[0], int.Parse(input[1]));

            
        }
        public static void PrintOutput(string youngerOrOlder,int age,string[] dataToPrint, Dictionary<string,int> people)
        {
            switch (youngerOrOlder)
            {
                case "younger":
                   
                    foreach (var person in people)
                    {
                        if (dataToPrint.Length == 1)
                        {
                            string nameOrAge = dataToPrint[0];
                            //=
                            if (person.Value < age)
                            {
                                if (nameOrAge == "name")
                                {
                                    Console.WriteLine(person.Key);
                                }
                                else
                                {
                                    Console.WriteLine(person.Value);
                                }
                            }
                        }
                        else
                        {
                            //=
                            if (person.Value < age)
                            {
                                Console.WriteLine($"{person.Key} - {person.Value}");
                            }
                        }
                    }
                    break;
                case "older":
                    foreach (var person in people)
                    {
                        if (dataToPrint.Length == 1)
                        {
                            string nameOrAge = dataToPrint[0];
                            if (person.Value >= age)
                            {
                                if (nameOrAge == "name")
                                {
                                    Console.WriteLine(person.Key);
                                }
                                else
                                {
                                    Console.WriteLine(person.Value);
                                }
                            }
                        }
                        else
                        {
                            if (person.Value >= age)
                            {
                                Console.WriteLine($"{person.Key} - {person.Value}");
                            }
                        }
                    }
                    break;
            }
        }
    }
}
