using System;

namespace _05.NumberInInterval
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number <= 100 && number >= -100)
            {
                Console.WriteLine("Yes");
            }
            else if (number != 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
