
using System;

namespace _02.PawnWars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] board = new char[8, 8];
            for (int i = 0; i < 8; i++)
            {
                char[] lineInp = Console.ReadLine().ToCharArray();

                for (int j = 0; j < 8; j++)
                {
                    board[i, j] = lineInp[j];
                }
            }
            int totalMoves = 0;
            int whiteRow = FindPawns(board)[0];
            int whiteCol = FindPawns(board)[1];
            int blackRow = FindPawns(board)[2];
            int blackCol = FindPawns(board)[3];


            //Console.WriteLine("whiteRow: "+whiteRow);
            //Console.WriteLine("moving");
            //whiteRow = MoveWhite(whiteRow);
            //Console.WriteLine(whiteRow);

            while (true)
            {
                string captures = CanCapture(whiteRow,whiteCol,blackRow,blackCol,totalMoves);
                if (captures.Equals("White"))
                {
                    Console.WriteLine($"Game over! {captures} capture on {GetCoordinates(blackRow,blackCol)}.");
                    break;
                }
                else if (captures.Equals("Black"))
                {
                    Console.WriteLine($"Game over! {captures} capture on {GetCoordinates(whiteRow, whiteCol)}.");
                    break;
                }
                whiteRow = MoveWhite(whiteRow);
                totalMoves++;
                //can black capture white?
                captures= CanCapture(whiteRow, whiteCol, blackRow, blackCol, totalMoves);
                if (captures.Equals("White"))
                {
                    Console.WriteLine($"Game over! {captures} capture on {GetCoordinates(blackRow, blackCol)}.");
                    break;
                }
                else if (captures.Equals("Black"))
                {
                    Console.WriteLine($"Game over! {captures} capture on {GetCoordinates(whiteRow, whiteCol)}.");
                    break;
                }
                blackRow = MoveBlack(blackRow);
                totalMoves++;
                if (whiteRow == 0)
                {
                    Console.WriteLine($"Game over! White pawn is promoted to a queen at {GetCoordinates(whiteRow, whiteCol)}.");
                    break;
                }
                else if (blackRow == 7)
                {
                    Console.WriteLine($"Game over! Black pawn is promoted to a queen at {GetCoordinates(blackRow, blackCol)}.");
                    break;
                }

            }

        }

        public static void PrintBoard(char[,] m)
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
        public static int[] FindPawns(char[,] m)
        {
            //0 - whiteRow
            //1 - whiteCol
            //2 - blackRow
            //3 - blackCol
            int[] result = new int[4];
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    if (m[i, j] == 'w')
                    {
                        result[0] = i;
                        result[1] = j;
                    }
                    else if (m[i, j] == 'b')
                    {
                        result[2] = i;
                        result[3] = j;
                    }
                }
            }
            return result;
        }
        public static int MoveWhite(int row)
        {
            return --row;
        }
        public static int MoveBlack(int row)
        {
            return ++row;
        }
        public static string CanCapture(int whiteRow, int whieCol, int blackRow, int blackCol, int moves)
        {
            string whoCanTake;
            if (moves % 2 == 0) whoCanTake = "White";
            else whoCanTake = "Black";
            if (Math.Abs(whieCol - blackCol) == 1 && whiteRow - blackRow == 1)
            {
                return whoCanTake;
            }
            
            return "no capture";
        }
        public static string GetCoordinates(int row, int col)
        {
            string res = "";
            switch (col)
            {
                case 0: res += "a"; break;
                case 1: res += "b"; break;
                case 2: res += "c"; break;
                case 3: res += "d"; break;
                case 4: res += "e"; break;
                case 5: res += "f"; break;
                case 6: res += "g"; break;
                case 7: res += "h"; break;
            }
            res += Math.Abs(8 - row) + "";
            return res;
        }
    }
}
