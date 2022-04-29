using System;
using System.Linq;

namespace _09._2X2SquaresInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixData = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = matrixData[0];
            int cols = matrixData[1];
            string[,] matrix = new string[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                string[] colsData = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = colsData[j];
                }
            }
            int numSquares = 0;
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    string currChar = matrix[i, j];


                    if (currChar.CompareTo(matrix[i + 1, j]) == 0 && currChar.CompareTo(matrix[i + 1, j + 1]) == 0
                        && currChar.CompareTo(matrix[i, j + 1]) == 0)
                    {
                        numSquares++;
                    }

                }
            }
            Console.WriteLine(numSquares);
        }
    }
}
