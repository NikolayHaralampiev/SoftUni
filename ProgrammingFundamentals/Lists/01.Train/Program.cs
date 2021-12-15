using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> wagons = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int capacity = int.Parse(Console.ReadLine());

            while (true)
            {
                string command = Console.ReadLine();
                string[] operations = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (command == "end")
                {
                    break;
                }

                if (operations[0] == "Add")
                {
                    wagons.Add(int.Parse(operations[1]));
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        //wagons[i] += int.Parse(operations[0]);
                        if (wagons[i] <= capacity)
                        {
                            wagons[i] += int.Parse(operations[0]);
                            if (wagons[i] > capacity)
                            {
                                wagons[i] -= int.Parse(operations[0]);
                                continue;
                            }

                            break;
                        }
                        //break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
