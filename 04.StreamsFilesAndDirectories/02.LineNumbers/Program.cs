using System;
using System.IO;

namespace _02.LineNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            string inputFilePath = @"..\..\..\..\Files\02input.txt";
            string outputFilePath = @"..\..\..\..\Files\02output.txt";

            RewriteFileWithLineNumbers(inputFilePath, outputFilePath);
        }
        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
           StreamReader reader= new StreamReader(inputFilePath);    
            StreamWriter writer= new StreamWriter(outputFilePath);
            using (writer)
            {
                using (reader)
                {
                      string line=reader.ReadLine();
                    int lineCount = 1;
                    while (line != null)
                    {
                       writer.WriteLine($"{lineCount}. {line}");
                        line=reader.ReadLine();
                        lineCount++;
                    }
                }
            }
        }
    }
}
