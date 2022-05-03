using System;
using System.Collections.Generic;

namespace _14.Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n=int.Parse(Console.ReadLine());
            Dictionary<string,Dictionary<string,int>> dic=new Dictionary<string,Dictionary<string,int>>();
            for (int i = 0; i < n; i++)
            {
                string[] inputData=Console.ReadLine().Split(" -> ",StringSplitOptions.RemoveEmptyEntries);
                string color=inputData[0];
                //if there is NO such color in the wardrobe
                if (!dic.ContainsKey(color))
                {
                    dic.Add(color, new Dictionary<string,int>());
                    //if the clothes are more than 1
                    if (inputData[1].Contains(','))
                    {
                        string[] clothes = inputData[1].Split(",");
                        //check if the cloth is already on the inside dic
                        foreach (string cloth in clothes)
                        {
                            //if there is no such cloth
                            if (!dic[color].ContainsKey(cloth))
                            {
                                dic[color].Add(cloth, 1);
                            }
                            else//increase the count
                            {
                                dic[color][cloth]++;
                            }
                        }
                    }
                    //if there is only one cloth
                    else
                    {
                        string cloth=inputData[1];
                        if (!dic[color].ContainsKey(cloth))
                        {
                            dic[color].Add(cloth, 1);
                        }
                        else//increase the count
                        {
                            dic[color][cloth]++;
                        }
                    }
                    
                }
                //if that color is already in the wardrobe
                else
                {
                    if (inputData[1].Contains(','))
                    {
                        string[] clothes = inputData[1].Split(",");
                        //check if the cloth is already on the inside dic
                        foreach (string cloth in clothes)
                        {
                            //if there is no such cloth
                            if (!dic[color].ContainsKey(cloth))
                            {
                                dic[color].Add(cloth, 1);
                            }
                            else//increase the count
                            {
                                dic[color][cloth]++;
                            }
                        }
                    }
                    //if there is only one cloth
                    else
                    {
                        string cloth = inputData[1];
                        if (!dic[color].ContainsKey(cloth))
                        {
                            dic[color].Add(cloth, 1);
                        }
                        else//increase the count
                        {
                            dic[color][cloth]++;
                        }
                    }
                }
            }
            bool isFound=false;
            string[] lookingFor=Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            string colorToLookFor=lookingFor[0];
            string pieceToLookFor=lookingFor[1];
            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key} clothes:");
                foreach(var cloth in item.Value)
                {
                    if (item.Key == colorToLookFor && cloth.Key == pieceToLookFor)
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                         Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                   
                }
            }
        }
    }
}
