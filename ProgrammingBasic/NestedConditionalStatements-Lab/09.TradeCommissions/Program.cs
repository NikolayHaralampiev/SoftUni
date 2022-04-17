using System;

namespace _09.TradeCommissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double capacity = double.Parse(Console.ReadLine());
            double comission = 0.00;

            if (city == "Sofia")
            {
                if (0 <= capacity && capacity <= 500)
                {
                    comission = 0.05;
                }
                else if (500 < capacity && capacity <= 1000)
                {
                    comission = 0.07;
                }
                else if (1000 < capacity && capacity <= 10000)
                {
                    comission = 0.08;
                }
                else if (comission > 10000)
                {
                    comission = 0.12;
                }
            }
            else if (city == "Varna")
            {
                if (0 <= capacity && capacity <= 500)
                {
                    comission = 0.45;
                }
                else if (500 < capacity && capacity <= 1000)
                {
                    comission = 0.75;
                }
                else if (1000 < capacity && capacity <= 10000)
                {
                    comission = 0.10;
                }
                else if (comission > 10000)
                {
                    comission = 0.13;
                }
            }
            else if (city == "Plovdiv")
            {
                if (0 <= capacity && capacity <= 500)
                {
                    comission = 0.055;
                }
                else if (500 < capacity && capacity <= 1000)
                {
                    comission = 0.08;
                }
                else if (1000 < capacity && capacity <= 10000)
                {
                    comission = 0.12;
                }
                else if (comission > 10000)
                {
                    comission = 0.0145;
                }
            }
            else
            {
                Console.WriteLine("error");
            }

            Console.WriteLine($"{capacity * comission:F2}");
        }
    }
}
