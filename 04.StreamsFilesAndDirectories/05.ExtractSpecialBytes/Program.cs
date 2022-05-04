using System;
using System.Collections.Generic;
using System.IO;

namespace _05.ExtractSpecialBytes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string binaryFilePath = @"..\..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\..\Files\05output.bin";
        }
        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            StreamReader bytesReader = new StreamReader(bytesFilePath);
            using (bytesReader)
            {
                List<int> bytes = new List<int>();
                string line = bytesReader.ReadLine();
                while (line != null)
                {
                    bytes.Add(int.Parse(line));
                    line = bytesReader.ReadLine();
                }
            }
            
        }
    }
}
