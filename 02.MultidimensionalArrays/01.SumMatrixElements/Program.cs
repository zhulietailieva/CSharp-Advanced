using System;
using System.Linq;

namespace _01.SumMatrixElements
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] data =Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = data[0];
            int cols = data[1];
            int[,] matrix = new int[rows, cols];
            int sumOfElements = 0;

            for (int row = 0; row < rows; row++)
            {
                int[] colsData = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < colsData.Length; col++)
                {
                    matrix[row, col] = colsData[col];
                    sumOfElements+=colsData[col];
                }
            }
            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(  sumOfElements);

        }
        public static void PrintMatrix(int [,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]+" " );
                }
                Console.WriteLine();
            }
        }
    }
}
