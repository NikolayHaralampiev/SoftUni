using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Channels;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] operations = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (operations[0] == "Delete")
                {
                    numbers.RemoveAll(item => item == int.Parse(operations[1]));
                }

                else if (operations[0] == "Insert")
                {
                    numbers.Insert(int.Parse(operations[2])
                        , (int.Parse(operations[1])));
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
