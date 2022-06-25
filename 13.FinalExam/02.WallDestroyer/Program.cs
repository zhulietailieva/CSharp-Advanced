using System;
using System.Linq;

namespace _02.WallDestroyer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] wall = new char[size, size];
            //fill the wall
            for (int i = 0; i < size; i++)
            {
                char[] rowValues = Console.ReadLine().ToArray();
                for (int j = 0; j < size; j++)
                {
                    wall[i, j] = rowValues[j];
                }
            }
            int totalHoles = 0;
            int rodsHit = 0;
            string direction;
            bool electrocuted = false;

            while ((direction=Console.ReadLine()) != "End" && !electrocuted)
            {
                //get the coordinates
                int currRow = GetVankoCoordinates(wall)[0];
                int currCol = GetVankoCoordinates(wall)[1];
                
                int movedRow = Move(currRow, currCol, direction)[0];
                int movedCol = Move(currRow, currCol, direction)[1];
                //i should check if the coordinates after movemeent are valid
               bool areCurrCoordinatesValid = AreCoordinatesValid(movedRow, movedCol, size);
                if (!areCurrCoordinatesValid)
                {
                    //Console.WriteLine("Not valid");
                   // PrintMatrix(wall);
                    continue;
                }
                
                //if we come here, that means the cordinates are valid
                //if there's a rod on the new Position, he shouldn't move
                if (wall[movedRow, movedCol] == 'R')
                {
                    Console.WriteLine("Vanko hit a rod!");
                    rodsHit++;
                   // PrintMatrix(wall);
                    continue;
                }
                //if there is already a hole there
                if (wall[movedRow, movedCol] == '*')
                {
                    Console.WriteLine($"The wall is already destroyed at position [{movedRow}, {movedCol}]!");
                    //we move Vanko, but we don't increase the count
                    wall[currRow, currCol] = '*';
                    wall[movedRow, movedCol] = 'V';
                   // PrintMatrix(wall);
                    continue;
                }
                //i put a '*' on Vanko's initial place, which is now a hole
                totalHoles++;
                wall[currRow, currCol] = '*';
                //if the moved pos is a cable - he gets electrocuted and the program ends
                if (wall[movedRow, movedCol] == 'C')
                {
                    wall[movedRow, movedCol] = 'E';
                    totalHoles++;
                    electrocuted = true;
                   // PrintMatrix(wall);
                    continue;
                }               
                //if we reach here, that means that the new pos is a '-' 
                wall[movedRow, movedCol] = 'V';
               // PrintMatrix(wall);
            }
            //ouput if he gets electrocuted
            if (electrocuted)
            {
                Console.WriteLine($"Vanko got electrocuted, but he managed to make {totalHoles} hole(s).");
            }
            else
            {
                Console.WriteLine($"Vanko managed to make {(totalHoles+1)} hole(s) and he hit only {rodsHit} rod(s).");
            }
            PrintMatrix(wall);


        }
        public static void PrintMatrix(char[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write(m[i, j]);
                }
                Console.WriteLine();
            }
        }
        public static bool AreCoordinatesValid(int row, int col, int size)
        {
            if (row < 0 || col < 0 || row >= size || col >= size) return false;
            return true;           
        }
        public static int[] GetVankoCoordinates(char[,] m)
        {
            int[] coordinates = new int[2];
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    if (m[i, j] == 'V')
                    {
                        coordinates[0] = i;
                        coordinates[1] = j;
                    }
                }
            }
            return coordinates;
        }
        public static int[] Move(int row,int col,string direction)
        {
            int[] res=new int[2];
            switch (direction)
            {
                case "up":res = new int[2] { row - 1, col }; break;
                case "down": res = new int[2] { row +1, col }; break;
                case "left": res = new int[2] { row, col-1 }; break;
                case "right": res = new int[2] { row, col + 1 }; break;
            }
            return res;
        }

    }
}
