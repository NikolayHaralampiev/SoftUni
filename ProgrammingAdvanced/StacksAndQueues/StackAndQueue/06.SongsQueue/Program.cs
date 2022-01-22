using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _06.SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new Queue<string>(Console.ReadLine().Split(',').Select(s => s.Trim()));

            while (songs.Count > 1)
            {
                string commandLine = Console.ReadLine();
                int spaceIndex = commandLine.IndexOf(' ');
                string command;

                if (spaceIndex > 1)
                {
                    command = commandLine.Substring(0, spaceIndex);
                }
                else
                {
                    command = commandLine;
                }
                string newSong;

                switch (command)
                {
                    case "Play": songs.Dequeue(); break;
                    case "Add":
                        newSong = commandLine.Substring(spaceIndex + 1);
                        if (!songs.Contains(newSong))
                        {
                            songs.Enqueue(newSong);
                        }
                        else
                        {
                            Console.WriteLine($"{newSong} is already contained!");
                        }
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ", songs)); break;
                    default:
                        break;
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
