using System;

namespace _04.Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double[] counter = {0, 0, 0, 0, 0};

            for (int i = 0; i < number; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 200)
                {
                    counter[0]++;
                }
                else if (num < 400)
                {
                    counter[1]++;
                }
                else if (num < 600)
                {
                    counter [2]++;
                }
                else if (num < 800)
                {
                    counter [3]++;
                }
                else
                {
                    counter [4]++;
                }
            }

            Console.WriteLine($"{(counter[0] / number * 100):F2}%");
            Console.WriteLine($"{(counter[1] / number * 100):F2}%");
            Console.WriteLine($"{(counter[2] / number * 100):F2}%");
            Console.WriteLine($"{(counter[3] / number * 100):F2}%");
            Console.WriteLine($"{(counter[4] / number * 100):F2}%");
        }
    }
}
