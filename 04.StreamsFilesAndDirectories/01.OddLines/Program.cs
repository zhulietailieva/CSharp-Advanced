using System;
using System.IO;

namespace _01.OddLines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = @"..\..\..\..\Files\input.txt";
           // File.CreateText(@"..\..\..\Files\output.txt");
            string outputFilePath = @"..\..\..\..\Files\output.txt";
            

            ExtractOddLines(inputFilePath, outputFilePath);
        }
        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            StreamWriter writer=new StreamWriter(outputFilePath);
            StreamReader reader=new StreamReader(inputFilePath);
            using (writer)
            {
                using (reader)
                {
                    string line=reader.ReadLine();
                    int lineCount = 0;

                    while (line != null)
                    {
                        if (lineCount % 2 != 0)
                        {
                            writer.WriteLine(line);
                        }
                        line= reader.ReadLine();
                        lineCount++;

                    }
                }
            }
        }
    }
}
