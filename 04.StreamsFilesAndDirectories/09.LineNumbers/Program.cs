using System;
using System.IO;

namespace _09.LineNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = @"..\..\..\..\Files\09input.txt";
            string outputFilePath = @"..\..\..\..\Files\09output.txt";

            ProcessLines(inputFilePath, outputFilePath);


        }
        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            int lineCount = 1;
         StreamReader inputRead = new StreamReader(inputFilePath);
            StreamWriter outputWrite = new StreamWriter(outputFilePath);
            using (outputWrite)
            {
                using (inputRead)
                {
                    string line = inputRead.ReadLine();
                    while (line != null)
                    {
                        outputWrite.WriteLine($"Line {lineCount}: {line}");
                        line = inputRead.ReadLine();
                        lineCount++;


                    }
                }
            }
        }
    }
}
