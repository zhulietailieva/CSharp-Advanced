using System;
using System.Linq;

namespace _02.Armory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            //create the armory
            for (int i = 0; i < size; i++)
            {
                char[] values = Console.ReadLine().ToCharArray();
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = values[j];
                }
            }

            int currPrice = 0;
            int swordsBought = 0;

            while (true)
            {
                string direction = Console.ReadLine();
                int currRow = FindTheOfficer(matrix)[0];
                int currCol = FindTheOfficer(matrix)[1];
                int newRow = Move(direction, currRow, currCol)[0];
                int newCol= Move(direction, currRow, currCol)[1];
                //Console.WriteLine("new Row:"+newRow+", new Col:"+newCol);
                //check if the officer is out of the armory
                if (!isInMatrix(size, newRow, newCol))
                {
                    matrix[currRow, currCol] = '-';
                    Console.WriteLine("I do not need more swords!");
                    break;
                }
                //is the new pos a sword?
                if (isASword(matrix, newRow, newCol))
                {
                    matrix[currRow, currCol] = '-';
                    swordsBought++;
                    currPrice += (matrix[newRow, newCol]-'0');
                    matrix[newRow, newCol] = 'A';
                }
                //if not, is it a mirror?
                else if (isAMirror(newRow, newCol, matrix))
                {
                    matrix[currRow, currCol] = '-';
                    matrix[newRow, newCol] = '-';
                    for (int i = 0; i < size; i++)
                    {
                        for (int j = 0; j < size; j++)
                        {
                            if (isAMirror(i, j, matrix))
                            {
                                matrix[i, j] = 'A';
                            }
                        }
                    }
                }
                //its not a mirror, nor a sword and its in the armory
                else
                {
                    matrix[currRow, currCol] = '-';
                    matrix[newRow, newCol] = 'A';
                }
                //if we reach here the new pos is a '-', so I must check if I have collected 
                //enough coins
                //Console.WriteLine("currPrice: "+currPrice);
                //PrintMatrix(matrix);
                //Console.WriteLine();
                if (currPrice >= 65)
                {
                    Console.WriteLine("Very nice swords, I will come back for more!");
                break; 
                }                             
            }
            Console.WriteLine($"The king paid {currPrice} gold coins.");
            PrintMatrix(matrix);

        }
        public static void PrintMatrix(char[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write(m[i,j]);
                }
                Console.WriteLine();
            }
        }
        public static int[] Move(string direction,int currRow,int currCol)
        {
            int[] res=new int[2];
            switch (direction)
            {
                case "up":res = new int[2] { currRow - 1, currCol } ; break;
                case "down": res = new int[2] { currRow + 1, currCol }; break;
                case "left": res = new int[2] { currRow , currCol -1}; break;
                case "right": res = new int[2] { currRow, currCol +1  }; break;
            }
            return res;
        }
        public static int[] FindTheOfficer(char[,] m)
        {
            int[] res = new int[2];
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    if (m[i, j] == 'A')
                    {
                        res[0] = i;
                        res[1] = j;
                    }
                }
            }
            return res;
        }
        public static bool isInMatrix(int size,int row,int col)
        {
            if (row < 0 || col < 0 || row > size - 1 || col > size - 1) return false;
            return true;
        }
        public static bool isAMirror(int row,int col, char[,] m)
        {
            if (m[row, col] == 'M') return true;
            return false;
        }
        public static bool isASword(char[,]m,int row,int col)
        {
             if (m[row, col] - '0' >= 0 && m[row, col] - '0' < 10) return true;
           
            return false;
        }
    }
}
