using System;

namespace _05.DivisionWithoutRemainder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double[] counter = {0, 0, 0};

            for (int i = 0; i < number; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    counter[0]++;
                }

                if (num % 3 == 0)
                {
                    counter[1]++;
                }

                if (num % 4 == 0 )
                {
                    counter[2]++;
                }
            }

            Console.WriteLine($"{(counter[0] / number * 100):F2}%");
            Console.WriteLine($"{(counter[1] / number * 100):F2}%");
            Console.WriteLine($"{(counter[2] / number * 100):F2}%");
        }
    }
}
