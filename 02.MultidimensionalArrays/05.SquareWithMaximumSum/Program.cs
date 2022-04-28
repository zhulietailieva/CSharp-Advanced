using System;
using System.Linq;

namespace _05.SquareWithMaximumSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] data=Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = data[0];
            int cols = data[1];
            int[,] matrix=new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                int[] colData = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = colData[col];
                }
            }
            int biggestSum = int.MinValue;
            int biggestRow=0;
            int biggestCol=0;


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {

                    if (i + 1 < rows && j + 1 < cols)
                    {
                        
                        int squareSum = matrix[i, j] + matrix[i + 1, j] + matrix[i, j + 1] + matrix[i + 1, j + 1];
                        if (squareSum > biggestSum)
                        {
                            biggestSum = squareSum;
                            biggestRow = i;
                            biggestCol = j;
                        }
                    }
                }
                
            }
            Console.WriteLine(matrix[biggestRow, biggestCol] + " " + matrix[biggestRow, biggestCol + 1]);
            Console.WriteLine(matrix[biggestRow + 1, biggestCol] + " " + matrix[biggestRow + 1, biggestCol + 1]);
            Console.WriteLine(biggestSum);

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
