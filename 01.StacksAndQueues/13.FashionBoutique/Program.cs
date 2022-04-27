using System;
using System.Collections.Generic;
using System.Linq;

namespace _13.FashionBoutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Stack<int> clothes=new Stack<int>(Console.ReadLine().Split(' ').Select(int.Parse));
            int rackCapacity=int.Parse(Console.ReadLine());
            int rackCount = 1;
            int currClothes = 0;

            while(clothes.Count > 0)
            {
                int currCloth = clothes.Peek();
                if (currCloth + currClothes <= rackCapacity)
                {
                    currClothes += currCloth;
                    clothes.Pop();
                }
                else
                {
                    currClothes = currCloth;
                    clothes.Pop();
                    rackCount++;

                }
            }
            Console.WriteLine(rackCount);
        }
    }
}
