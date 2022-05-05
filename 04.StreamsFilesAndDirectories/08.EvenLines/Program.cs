using System;
using System.IO;
using System.Linq;
using System.Text;

namespace _08.EvenLines
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            string inputFilePath = @"..\..\..\..\Files\08text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }
        public static string ProcessLines(string inputFilePath)
        {          

            StreamReader sr = new StreamReader(inputFilePath);
            using (sr)
            {
 StringBuilder sb = new StringBuilder();
            int linesCount = 0;
            string line = sr.ReadLine();
                char[] replacements = new char[] { '-', ',', '.', '!', '?' };
            while (line != null)
            {
                   
                if (linesCount % 2 == 0)
                {
                        foreach (var symbol in replacements)
                        {
                           line= line.Replace(symbol, '@');
                        }
                        line = string.Join(" ", line.Split(" ").Reverse());
                    sb.AppendLine(line);
                }
                line = sr.ReadLine();
                linesCount++;
            }
            return sb.ToString();
            }
           

        }
    }
}
