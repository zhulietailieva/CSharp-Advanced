using System;
using System.Linq;

namespace _06.Jagged_ArrayModification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                int[] colData = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = colData[j];
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] cmndData = command.Split(' ');
                if (cmndData[0] == "Add")
                {
                    int i = int.Parse(cmndData[1]);
                    int j = int.Parse(cmndData[2]);
                    int value = int.Parse(cmndData[3]);
                    if (i < 0 || i >= size || j < 0 || j >= size)
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                    else
                    {
                        matrix[i, j] += value;
                    }

                }
                else if (cmndData[0] == "Subtract")
                {
                    int i = int.Parse(cmndData[1]);
                    int j = int.Parse(cmndData[2]);
                    int value = int.Parse(cmndData[3]);
                    if (i < 0 || i >= size || j < 0 || j >= size)
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                    else
                    {
                        matrix[i, j] -= value;
                    }
                  
                }
            }
            PrintMatrix(matrix);
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
