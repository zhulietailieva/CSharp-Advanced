using System;
using System.Collections.Generic;

namespace _06.GenericCountMethodDouble
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<double> elements = new List<double>();

            int nListElements = int.Parse(Console.ReadLine());
            for (int i = 0; i < nListElements; i++)
            {
                elements.Add(double.Parse(Console.ReadLine()));
            }
            double elementForComparison =double.Parse( Console.ReadLine());
            Console.WriteLine(Compare<string>(elements, elementForComparison));
        }
        public static int Compare<T>(List<double> list, double itemToCompare)
        {
            int greaterItems = 0;
            bool isString = false;
            if (itemToCompare.GetType().ToString() == "System.String")
            {
                isString = true;
            }
            if (isString)
            {
                foreach (var item in list)
                {
                    
                    if (item.CompareTo(itemToCompare.ToString()) > 0)
                    {
                        greaterItems++;
                    }
                }
            }
            else
            {
                foreach (var item in list)
                {
                    if (item-itemToCompare>0)
                    {
                        greaterItems++;
                    }
                }
            }
            return greaterItems;
        }
    }
}
