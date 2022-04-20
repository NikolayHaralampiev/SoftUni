using System;

namespace _05.AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double add = double.Parse(Console.ReadLine());
            string input;
            double total = 0.0;
            while ((input = Console.ReadLine()) != "NoMoreMoney")
            {
                if (double.Parse(input) < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {double.Parse(input):f2}");
                total += double.Parse(input);
            }
            Console.WriteLine($"Total: {total:f2}");
        }
    }
}
