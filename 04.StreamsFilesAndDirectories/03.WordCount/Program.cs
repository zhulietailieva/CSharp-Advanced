using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03.WordCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textFilePath = @"..\..\..\..\Files\text.txt";
            string wordsFilePath = @"..\..\..\..\Files\words.txt";
            string outputFilePath = @"..\..\..\..\Files\03output.txt";

            CalculateWordCounts(wordsFilePath, textFilePath, outputFilePath);
        }
        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            StreamReader readerWords=new StreamReader(wordsFilePath);
            using (readerWords)
            {
               
                string input=readerWords.ReadToEnd();
                string[] wordsToCount=input.Split(' ');
               Dictionary<string, int> dic=new Dictionary<string, int>();
                foreach (string word in wordsToCount)
                {
                    dic[word]=0;
                }

                StreamWriter writer=new StreamWriter(outputFilePath);
                using (writer)
                {
                    StreamReader textReader = new StreamReader(textFilePath);
                    using (textReader)
                    {
                        string[] wordsInText=textReader.ReadToEnd().Split(new char[] { ' ',',','.','-','?','!'},
                            StringSplitOptions.RemoveEmptyEntries);
                        
                       
                        for (int i = 0; i < wordsToCount.Length; i++)
                        {
                            string currWord = wordsToCount[i];
                           
                            for (int j = 0; j < wordsInText.Length; j++)
                            {
                                string currWordInText=wordsInText[j];
                                
                               
                                if (currWord.ToUpper().Equals(wordsInText[j].ToUpper()))
                                {
                                    dic[currWord]++;
                                }
                            }
                            
                        }
                        dic=dic.OrderByDescending(x=>x.Value).ToDictionary(dic=>dic.Key, dic=>dic.Value);
                        foreach (var item in dic)
                        {
                            writer.WriteLine($"{item.Key} - {item.Value}");
                            Console.WriteLine($"{item.Key} - {item.Value}");
                        }
                    }
                }
            }
            
        }
    }
}
