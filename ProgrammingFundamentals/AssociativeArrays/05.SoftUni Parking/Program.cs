using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _05.SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> dict = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split()
                    .ToArray();
                string command = input[0];
                string userName = input[1];

                if (command == "unregister" && !dict.ContainsKey(userName))
                {
                    Console.WriteLine($"ERROR: user {userName} not found");
                    continue;
                }
                else if (command == "unregister" && dict.ContainsKey(userName))
                {
                    Console.WriteLine($"{userName} unregistered successfully");
                    dict.Remove(userName);
                    continue;
                }

                string licensePlate = input[2];

                if (command == "register" && !dict.ContainsKey(userName))
                {
                    dict.Add(userName, licensePlate);
                    Console.WriteLine($"{userName} registered {licensePlate} successfully");
                    continue;
                }
                else if (command == "register" && dict.ContainsKey(userName))
                {
                    Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                    continue;
                }
            }

            foreach (var user in dict )
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
