using System;
using System.Linq;

namespace _11.MatrixShuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputData=Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = inputData[0];
            int cols = inputData[1];
            string[,] m = new string[rows, cols];
            for (int i = 0; i < rows; i++)
            {
               string[] colsData=Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < cols; j++)
                {
                    m[i,j]=colsData[j];

                }
            }
            string command;
            while((command = Console.ReadLine()) != "END")
            {
                string[] commandData=command.Split(' ',StringSplitOptions.RemoveEmptyEntries);
                if(commandData[0] == "swap"&&commandData.Length==5)
                {
                    int row1=int.Parse(commandData[1]);
                    int col1=int.Parse(commandData[2]);
                    int row2=int.Parse(commandData[3]);
                    int col2=int.Parse(commandData[4]);
                    if(row1>rows-1||row1<0||
                       row2 > rows - 1 || row2 < 0 ||
                       col1> cols-1||col1 < 0 ||
                       col2 > cols-1|| col2 < 0)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                       string temp = m[row1, col1];                      
                       m[row1, col1] = m[row2, col2];
                        m[row2, col2] = temp;

                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < cols; j++)
                            {
                                Console.Write(m[i,j]+" ");
                            }
                            Console.WriteLine();
                        }
                    }
                       
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }

        }
    }
}
