using System;

namespace _07.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string command = Console.ReadLine();
            double sumCoins = 0;

            while (command != "Start")
            {
                double coins = double.Parse(command);

                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    sumCoins += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();
            double price = 0;

            while (command != "End")
            {
                if (command == "Nuts")
                {
                    price = 2.0;
                }
                else if (command == "Water")
                {
                    price = 0.7;
                }
                else if (command == "Crisps")
                {
                    price = 1.5;
                }
                else if (command == "Soda")
                {
                    price = 0.8;
                }
                else if (command == "Coke")
                {
                    price = 1.0;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                    command = Console.ReadLine();
                    continue;
                }

                if (sumCoins >= price)
                {
                    Console.WriteLine($"Purchased {command.ToLower()}");
                    sumCoins -= price;
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Change: {sumCoins:F2}");
        }
    }
}
