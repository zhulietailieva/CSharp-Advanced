
using System;
using System.IO;

namespace _04.MergeFiles
{
    

    internal class Program
    {
        static void Main(string[] args)
        {
            string firstInputFilePath = @"..\..\..\..\Files\04input1.txt";
            string secondInputFilePath = @"..\..\..\..\Files\04input2.txt";
            string outputFilePath = @"..\..\..\..\Files\04output.txt";
            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }
        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            StreamWriter writer = new StreamWriter(outputFilePath);
            using (writer)
            {
                StreamReader file1reader = new StreamReader(firstInputFilePath);
                StreamReader file2reader = new StreamReader(secondInputFilePath);

                using (file1reader)
                {
                    using (file2reader)
                    {

                        string lineInp1 = file1reader.ReadLine();
                        string lineInp2 = file2reader.ReadLine();

                        while (lineInp1 != null && lineInp2 != null)
                        {
                            writer.WriteLine(lineInp1);
                            writer.WriteLine(lineInp2);
                            lineInp1 = file1reader.ReadLine();
                            lineInp2 = file2reader.ReadLine();

                        }
                        if (lineInp1 != null)
                        {
                            while (lineInp1 != null)
                            {
                                writer.WriteLine(lineInp1);
                                lineInp1 = file1reader.ReadLine();
                            }
                        }
                        if (lineInp2 != null)
                        {
                            while (lineInp2 != null)
                            {
                                writer.WriteLine(lineInp1);
                                lineInp2 = file2reader.ReadLine();
                            }
                        }
                    }
                }
                

            }
        }
    }
    }

