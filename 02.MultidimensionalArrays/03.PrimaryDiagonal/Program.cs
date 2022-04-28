using System;
using System.Linq;

namespace _03.PrimaryDiagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int [,] matrix=new int[size,size];

            for (int row = 0; row < size; row++)
            {
                int[] colData=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row,col] = colData[col];
                }
            }
            int diagonalSum = 0;

            for (int i = 0; i < size; i++)
            {
               diagonalSum+=matrix[i,i];
            }
            Console.WriteLine(diagonalSum);

        }
    }
}
