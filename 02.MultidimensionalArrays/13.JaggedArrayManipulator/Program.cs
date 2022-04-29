using System;
using System.Linq;

namespace _13.JaggedArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N=int.Parse(Console.ReadLine());
            double[][] jagged=new double[N][];    
            for(int i=0; i<N; i++)
            {
                jagged[i] =Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    jagged[i][j] = jagged[i][j];

                }
                
            }

            

            for (int i = 0; i < jagged.Length-1; i++)
            {
                if (jagged[i].Length == jagged[i + 1].Length)
                {
                    for (int j = 0; j < jagged[i].Length; j++)
                    {
                        jagged[i][j] *= 2;
                        jagged[i + 1][j] *= 2;
                    }
                }
                else
                {
                    for (int j = 0; j < jagged[i].Length; j++)
                    {
                        //2.0?
                        jagged[i][j] /= 2;
                        
                    }
                    for (int j = 0; j < jagged[i+1].Length; j++)
                    {
                        jagged[i+1][j] /= 2;
                    }
                }
            }
            //printM(jagged);
            string command;
            while( true)
            {
                command = Console.ReadLine();
                string[] commandData=command.Split(' ',StringSplitOptions.RemoveEmptyEntries);
                if (commandData[0] == "Add")
                {
                    
                   int row=int.Parse(commandData[1]);
                    int col=int.Parse(commandData[2]);

                    double value=double.Parse(commandData[3]);
                    if (row > -1 && row < jagged.Length && col > -1 && col < jagged[row].Length)
                    {
                        jagged[row][col] += value;
                    }
                }
                else if(commandData[0] == "Subtract")
                {
                    
                    char rowChar = commandData[1].ToCharArray()[0];
                    char colChar=commandData[2].ToCharArray()[0];
                    if (char.IsDigit(rowChar) && char.IsDigit(colChar))
                    {
                    int row = int.Parse(commandData[1]);
                    int col = int.Parse(commandData[2]);

                    double value = double.Parse(commandData[3]);
                    if (row > -1 && row < jagged.Length && col > -1 && col < jagged[row].Length)
                    {
                        jagged[row][col] -= value;
                    }

                    }                 
                }
                else if(commandData[0] == "End")
                {
                    printM(jagged);
                    return;
                }
               
            }
            printM(jagged);
        }
        public static void printM(double[][] jagged)
        {
            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write(jagged[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
