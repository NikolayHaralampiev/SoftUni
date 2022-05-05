using System;

namespace _09.SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int totalAmount = 0;
            int days = 0;

            while (start >= 100)
            {
                totalAmount += start - 26;
                days++;
                start -= 10;
            }

            if (days > 0)
            {
                totalAmount -= 26;
            }

            Console.WriteLine(days);
            Console.WriteLine(totalAmount);

        }
    }
}
