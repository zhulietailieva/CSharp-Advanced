
using System;
using System.IO;

namespace _04.MergeFiles
{
    //not working - has to be fixed

    internal class Program
    {
        static void Main(string[] args)
        {
            string firstInputFilePath = @"..\..\..\..\Files\04input1.txt";
            string secondInputFilePath = @"..\..\..\..\Files\04input2.txt";
            string outputFilePath = @"..\..\..\..\Files\04output.txt";
            MergeTextFiles(firstInputFilePath,secondInputFilePath,outputFilePath);
        }
        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            StreamWriter writer = new StreamWriter(outputFilePath);
          //using (writer)
          //{
            StreamReader file1reader=new StreamReader(firstInputFilePath);
            StreamReader file2reader=new StreamReader(secondInputFilePath);
            
            
            int file1L = file1reader.ReadToEnd().Length;
            int file2L = file2reader.ReadToEnd().Length;
            
            

                Console.WriteLine(file1reader.ReadLine());
            
            if (file1L >= file2L)
            {
                    Console.WriteLine("here");
                using (file1reader)
                {
                    using (file2reader)
                    {
                       
                        string file1Line = file1reader.ReadLine();
                        string file2Line = file2reader.ReadLine();
                        while (file1Line != null && file2Line != null)
                        {
                                writer.WriteLine(file1Line);
                                writer.WriteLine(file2Line);
                                Console.WriteLine(file1Line);
                                Console.WriteLine(file2Line);
                                file1Line = file1reader.ReadLine();
                                file2Line = file2reader.ReadLine();

                        }
                    }
                        string file1LinesLeft = file1reader.ReadLine();
                    while(file1LinesLeft != null)
                        {
                            writer.WriteLine(file1LinesLeft);
                            Console.WriteLine(file1LinesLeft);
                            file1LinesLeft = file1reader.ReadLine();
                            
                        }
                }
            }
            else
            {
                    string file1Line = file1reader.ReadLine();
                    string file2Line = file2reader.ReadLine();
                    Console.WriteLine("here1");
                    Console.WriteLine(file1Line + " line 1");
                    Console.WriteLine(file2Line + " line 2");
                    using (file2reader)
                {
                    using (file1reader)
                    {
                            
                            //string file1Line = file1reader.ReadLine();
                            //string file2Line = file2reader.ReadLine();
                            //tuk gurmi te sa null zashto?
                            Console.WriteLine(file1Line+" line 1");
                            Console.WriteLine(file2Line+" line 2");
                            while (file1Line != null && file2Line != null)
                            {
                                writer.WriteLine(file1Line);
                                writer.WriteLine(file2Line);
                                Console.WriteLine(file1Line);
                                Console.WriteLine(file2Line);
                                file1Line = file1reader.ReadLine();
                                file2Line = file2reader.ReadLine();
                            }
                        }
                        string file2LinesLeft = file2reader.ReadLine();
                        while (file2LinesLeft != null)
                        {
                            writer.WriteLine(file2LinesLeft);
                            Console.WriteLine(file2LinesLeft);
                            file2LinesLeft = file2reader.ReadLine();

                        }
                    }
                }
            }
         // }
          }
        
    }

