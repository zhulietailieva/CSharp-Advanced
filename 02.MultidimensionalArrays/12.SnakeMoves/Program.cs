using System;
using System.Linq;

namespace _12.SnakeMoves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = inputData[0];
            int cols = inputData[1];
            string snake=Console.ReadLine();
            int currChar = 0;
            char[,] matrix=new char[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < cols; j++)
                    {              
                   if (currChar > snake.Length - 1)
                    {
                        currChar = 0;
                    }                   
                   
                   matrix[i, j] = snake.ToCharArray()[currChar];
                    currChar++;               
                }
                }
                else
                {
                    for (int j = cols - 1; j >= 0; j--)
                    {
                        if (currChar > snake.Length - 1)
                        {
                            currChar = 0;
                        }

                        matrix[i, j] = snake.ToCharArray()[currChar];
                        currChar++;
                    }
                }             
                
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
