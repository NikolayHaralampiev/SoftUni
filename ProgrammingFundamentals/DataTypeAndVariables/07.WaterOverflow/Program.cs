using System;

namespace _07.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int capacity = 255;

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int include = int.Parse(Console.ReadLine());

                if (sum + include > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    sum += include;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
