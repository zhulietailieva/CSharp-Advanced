using System;
using System.Linq;

namespace _10.MaximalSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //always write stringSplitOptions.RemoveEmptyEntries
           int[] inputData=Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = inputData[0];
            int cols = inputData[1];
            int [,] rect=new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                int[] colsData=Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < colsData.Length; col++)
                {
                    rect[row,col] = colsData[col];

                }
            }
            int MaxSum = int.MinValue;
            int outputRow = -1;
            int outputCol = -1;
            for (int i = 0; i < rows-2; i++)
            {
                for (int j = 0; j < cols-2; j++)
                {
                    int currSum = rect[i, j] +     rect[i, j + 1] +     rect[i, j + 2] +
                                  rect[i + 1, j] + rect[i + 1, j + 1] + rect[i + 1, j + 2] +
                                  rect[i + 2, j] + rect[i + 2, j + 1] + rect[i + 2, j + 2];
                    //=>
                    if(currSum > MaxSum)
                    {
                        MaxSum = currSum;
                        outputRow=i;
                        outputCol=j;

                    }
                }
            }
            Console.WriteLine("Sum = "+MaxSum);
            Console.WriteLine(rect[outputRow, outputCol]+" " + rect[outputRow, outputCol + 1] + " " + rect[outputRow, outputCol + 2]);
            Console.WriteLine(rect[outputRow + 1, outputCol] + " " + rect[outputRow + 1, outputCol + 1] + " " + rect[outputRow + 1, outputCol + 2]);
            Console.WriteLine(rect[outputRow + 2, outputCol] + " " + rect[outputRow + 2, outputCol + 1] + " " + rect[outputRow + 2, outputCol + 2]);
        }
    }
}
