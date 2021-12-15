using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string lineOne = "is going!";
            string lineTwo = "in not going";
            List<string> people = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                string[] operations = command.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = operations[0];

                if (command.Contains(lineOne))
                {
                    if (people.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        people.Add(name);
                    }
                }
                else if (command.Contains(lineTwo))
                {
                    if (people.Contains(name))
                    {
                        people.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }

            for (int i = 0; i < people.Count; i++)
            {
                Console.WriteLine(people[i]);
            }
        }
    }
}
