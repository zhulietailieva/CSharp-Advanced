using System;
using System.Linq;

namespace _02.SumMatrixColumns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data=Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = data[0];
            int cols = data[1];
            int [,] matrix=new int[rows, cols];
            for (int row = 0; row < rows    ; row++)
            {
                int[] colData = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                for (int col = 0; col < cols ; col++)
                {
                    matrix[row, col] = colData[col];
                }

            }
            for (int col = 0; col < cols; col++)
            {
                int colSum = 0;
                for (int row = 0; row < rows ; row++)
                {
                    colSum+=matrix[row, col];
                }
                Console.WriteLine(colSum);
            }

        }
        public static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
