using System;
using System.IO;
using System.Linq;

namespace _07.FolderSize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string folderPath = @"..\..\..\..\Files\TestFolder";
            string outputFilePath = @"..\..\..\..\Files\07.output.txt";

            float size = GetFolderSize(folderPath);
            StreamWriter writer = new StreamWriter(outputFilePath);
            using (writer)
            {
                writer.WriteLine(size);
            }

        }
        public static float GetFolderSize(string folderPath)
        {
            DirectoryInfo info = new DirectoryInfo(folderPath);
            float folderSize = 0;
            foreach (string file in Directory.GetFiles(folderPath))
            {
                if (File.Exists(file))
                {
                    FileInfo finfo = new FileInfo(file);
                    folderSize += finfo.Length;
                }
            }
            foreach(string dir in Directory.GetDirectories(folderPath))
            {
                folderSize += GetFolderSize(dir);
            }
            return folderSize;
        }
    }
}
