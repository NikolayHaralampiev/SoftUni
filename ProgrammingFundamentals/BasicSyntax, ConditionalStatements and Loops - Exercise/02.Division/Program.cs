using System;

namespace _02.Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numBig = 0;

            if (number % 2 == 0)
            {
                numBig = 2;
            }

            if (number % 3 == 0)
            {
                numBig = 3;
            }

            if (number % 6 == 0)
            {
                numBig = 6;
            }

            if (number % 7 == 0)
            {
                numBig = 7;
            }

            if (number % 10 == 0)
            {
                numBig = 10;
            }

            if (numBig == 0)
            {
                Console.WriteLine("Not divisible");
            }
            else
            {
                Console.WriteLine($"The number is divisble by {numBig}");
            }
        }
    }
}
