using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string command = Console.ReadLine();
                string[] operations = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (command == "End")
                {
                    break;
                }

                if (operations[0] == "Add")
                {
                    numbers.Add(int.Parse(operations[1]));
                }

                else if (operations[0] == "Remove")
                {
                    if (int.Parse(operations[1]) < 0 || int.Parse(operations[1]) >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(int.Parse(operations[1]));
                    }
                }

                else if (operations[0] == "Insert")
                {
                    if (int.Parse(operations[2]) >= 0 && int.Parse(operations[2]) < numbers.Count)
                    {
                        numbers.Insert(int.Parse(operations[2])
                            , (int.Parse(operations[1])));
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }

                else if (operations[0] == "Shift")
                {
                    int shifting = int.Parse(operations[2]);
                    if (operations[1] == "left")
                    {
                        for (int i = 0; i < shifting; i++)
                        {
                            numbers.Add(numbers[0]);
                            numbers.Remove(numbers[0]);
                        }
                    }

                    else if (operations[1] == "right")
                    {
                        for (int i = 0; i < shifting; i++)
                        {
                            //var first = numbers.First();
                            //var last = numbers.Last();                         
                            numbers.Insert(0,
                                numbers[numbers.Count - 1]); // Просто гола нула за индекс                     
                            numbers.RemoveAt(numbers.Count - 1);
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    
    }
}
