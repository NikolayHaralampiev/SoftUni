using System;

namespace _10._MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int from = 1;
            int to = 11;

            for (int i = from; i < to; i++)
            {
                Console.WriteLine($"{number} X {i} = {number*i}");
            }
        }
    }
}
