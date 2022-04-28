using System;

namespace _07.PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            long[][] jagged = new long[rows][];
            jagged[0] = new long[1] { 1 };
            for (int i = 1; i < rows; i++)
            {
                jagged[i] = new long[i + 1];
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    if (j == 0 || j == jagged[i].Length-1)
                    {
                        jagged[i][j] = 1;
                    }
                    else
                    {
                        jagged[i][j] = jagged[i - 1][j] + jagged[i - 1][j - 1];
                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {
                long[] colData = jagged[i];
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write(jagged[i][j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
