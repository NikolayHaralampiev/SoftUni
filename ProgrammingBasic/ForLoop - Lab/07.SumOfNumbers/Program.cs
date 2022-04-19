using System;

namespace _07.SumOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int value = 0;

            for (int i = 0; i < number; i++)
            {
                int sumNumber = int.Parse(Console.ReadLine());
                value += sumNumber;
            }
            Console.WriteLine(value);
        }
    }
}
