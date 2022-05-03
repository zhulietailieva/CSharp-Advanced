using System;
using System.IO;

namespace _01.OddLines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"..\..\..\Files");
           
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

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
                    int i = 0;
                    while(line != null)
                    {
                        if (i % 2 == 0)
                        {
                           writer.WriteLine(line);
                        }
                        i++;
                        line = reader.ReadLine();
                    }

                }
            }
        }
    }
}
