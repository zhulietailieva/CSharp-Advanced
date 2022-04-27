using System;
using System.Collections;
using System.Collections.Generic;

namespace _14.SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new Queue<string>(Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries));
            string line;
            while(songs.Count > 0)
            {
                line=Console.ReadLine();
                string[] commandInfo = line.Split(' ');

                if (commandInfo[0].Equals("Play"))
                {
                    songs.Dequeue();

                }
                else if (commandInfo[0].Equals("Add"))
                {
                    string newSong = line.Substring(4);
                    if (songs.Contains(newSong))
                    {
                        Console.WriteLine($"{newSong} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(newSong);
                    }
                }
                else if (commandInfo[0].Equals("Show"))
                {
                    Console.WriteLine(string.Join(", ",songs));
                }

            }
            Console.WriteLine("No more songs!");

        }
    }
}
