using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BakeryShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Croissant – consists of 50 % water and 50 % flour
            //Muffin – consists of 40 % water and 60 % flour
            //Baguette – consists of 30 % water and 70 % flour
            //Bagel – consists of 20 % water and 80 % flour

            Queue<double> water = new Queue<double>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse));
            Stack<double> flour = new Stack<double>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse));

            
            Dictionary<string, int> products = new Dictionary<string, int>();
            products.Add("Croissant", 0);
            products.Add("Muffin", 0);
            products.Add("Baguette", 0);
            products.Add("Bagel", 0);

            while (water.Count > 0 && flour.Count > 0)
            {
                double currWater = water.Dequeue();
                double currFlour = flour.Pop();
                int percentageWater =(int) (currWater * 100) / (int)(currWater + currFlour);
                int percentageFlour = (int)(currFlour * 100) / (int)(currWater + currFlour);

               

                if (percentageWater == 50 && percentageFlour == 50)
                {
                    //croissant
                    products["Croissant"]++;
                    


                }
                else if (percentageWater == 40 && percentageFlour == 60)
                {
                    //muffin
                    products["Muffin"]++;

                }
                else if (percentageWater == 30 && percentageFlour == 70)
                {
                    //baguette
                    products["Baguette"]++;

                }
                else if (percentageWater == 20 && percentageFlour == 80)
                {
                    //bagel
                    products["Bagel"]++;

                }
                else
                {
                    double flourLeft = currFlour - currWater;
                    products["Croissant"]++;
                    flour.Push(flourLeft);
                }
            }
 
            var sortedProducts = new Dictionary<string, int>
                (products.OrderByDescending(x => x.Value).ThenBy(x => x.Key));
            foreach (var product in sortedProducts)
            {
                if (product.Value == 0) continue;
                Console.WriteLine($"{product.Key}: {product.Value}");
            }
            if (water.Count == 0)
            {
                Console.WriteLine("Water left: None");
            }
            else
            {
                Console.WriteLine($"Water left: {string.Join(", ",water)}");
            }
            if (flour.Count == 0)
            {
                Console.WriteLine("Flour left: None");
            }
            else
            {
                Console.WriteLine($"Flour left: {string.Join(", ", flour)}");
            }
        }
    }
}
