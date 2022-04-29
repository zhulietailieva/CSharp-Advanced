using System;
using System.Linq;

namespace _08.DiagonalDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                int[] colData = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < colData.Length; j++)
                {
                    matrix[i, j] = colData[j];
                }
            }
            int sumDiagonal1 = 0;
            int sumDiagonal2 = 0;
            for (int i = 0; i < n; i++)
            {
                sumDiagonal1 += matrix[i, i];
            }
            for (int i = 0,j=n-1; i < n; i++,j--)
            {
                sumDiagonal2 += matrix[i, j];
            }
            Console.WriteLine(Math.Abs(sumDiagonal2-sumDiagonal1));
        }
    }
}
