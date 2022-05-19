using System;
using System.Collections.Generic;

namespace _07.Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            string[] nameAndAddress = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string name = nameAndAddress[0] + " " + nameAndAddress[1];
            Tuple<string, string> nameAddress = new Tuple<string, string>(name,nameAndAddress[2]);

            string[] nameAndBeer = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Tuple<string, double> nameBeer = new Tuple<string, double>(nameAndBeer[0], double.Parse(nameAndBeer[1]));

            string[] intAndDouble = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Tuple<int, double> intDouble = new Tuple<int, double>
                (int.Parse(intAndDouble[0]), double.Parse(intAndDouble[1]));

            Console.WriteLine($"{nameAddress.Item1} -> {nameAddress.Item2}");
            Console.WriteLine($"{nameBeer.Item1} -> {nameBeer.Item2}");
            Console.WriteLine($"{intDouble.Item1} -> {intDouble.Item2}");
        }
    }
}
