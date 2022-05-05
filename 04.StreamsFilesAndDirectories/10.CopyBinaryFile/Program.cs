using System;
using System.IO;

namespace _10.CopyBinaryFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = @"..\..\..\..\FIles\CopyMe.png";
            string outputFilePath = @"..\..\..\..\FIles\CopyMeCopy.png";
            CopyFile(inputFilePath, outputFilePath);
        }
        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
         using   FileStream fileStreamReader = new FileStream(inputFilePath, FileMode.Open);
         using   FileStream fileStreamWriter = new FileStream(outputFilePath, FileMode.Create);

            byte[] bytesToCopy = new byte[128];
            while (true)
            {
                int currBytes = fileStreamReader.Read(bytesToCopy, 0, bytesToCopy.Length);
                if (currBytes == 0)
                {
                    break;
                }
                fileStreamWriter.Write(bytesToCopy, 0, bytesToCopy.Length);
            }

        }
    }
}
