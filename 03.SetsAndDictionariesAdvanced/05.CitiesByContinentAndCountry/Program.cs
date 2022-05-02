using System;
using System.Collections.Generic;

namespace _05.CitiesByContinentAndCountry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfInputs = int.Parse(Console.ReadLine());
            Dictionary<string,Dictionary<string,List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < numOfInputs; i++)
            {
                string[] inputData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string contName=inputData[0];
                string countryName=inputData[1];
                string cityName=inputData[2];
                //if there is no such continent in the dictionary
                if (!continents.ContainsKey(contName))
                {
                    continents.Add(contName, new Dictionary<string, List<string>>() );
                    continents[contName].Add(countryName, new List<string> (){cityName });
                }
                //if there is such continent in the dictionary
                else
                {
                    //if there is no such country in that continent
                    if (!continents[contName].ContainsKey(countryName))
                    {
                        //add the country and the city
                        continents[contName].Add(countryName, new List<string>() { cityName});
                       
                    }
                    //if there is no such city in that country in  that continent
                    else
                    {
                        continents[contName][countryName].Add(cityName);
                    }
                }
            }
            foreach (var continent in continents)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var country in continent.Value)
                {
                    Console.Write($"{country.Key} -> ");
                    Console.WriteLine(string.Join(", ",country.Value));
                }
            }
        }
    }
}
