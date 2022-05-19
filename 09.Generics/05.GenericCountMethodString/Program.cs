using System;
using System.Collections.Generic;

namespace _05.GenericCountMethodString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<string> elements = new List<string>();

            int nListElements = int.Parse(Console.ReadLine());
            for (int i = 0; i < nListElements; i++)
            {
                elements.Add(Console.ReadLine());
            }
            String elementForComparison = Console.ReadLine();
            Console.WriteLine(Compare<string>(elements,elementForComparison));
        }
        public static int Compare<T>(List<String> list, T itemToCompare)
        {
            int greaterItems = 0;
            bool isString = false;
            if(itemToCompare.GetType().ToString()== "System.String")
            {
                isString = true;
            }
            if (isString)
            {
                foreach (string item in list)
                {
                    //moje i da e >0
                    if (item.CompareTo(itemToCompare.ToString()) > 0)
                    {
                        greaterItems++;
                    }
                }
            }
            return greaterItems;
        }
    }
}
