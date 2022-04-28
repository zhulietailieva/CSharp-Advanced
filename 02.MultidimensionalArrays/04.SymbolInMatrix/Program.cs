using System;

namespace _04.SymbolInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix=new char[n,n];
            for (int row = 0; row < n; row++)
            {
                char[] symbols = Console.ReadLine().ToCharArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row,col] = symbols[col];
                }
            }
            char symbolToFind=Console.ReadLine().ToCharArray()[0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(matrix[i,j] == symbolToFind)
                    {
                        Console.WriteLine($"({i}, {j})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{symbolToFind} does not occur in the matrix");
        }
    }
}
