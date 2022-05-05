using System;

namespace _10.Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int halfOfN = n / 2;

            int targets = 0;

            while (n >= m)
            {
                targets++;
                n -= m;

                if (halfOfN == n && y > 0)
                {
                    n /= y;
                }

            }

            Console.WriteLine(n);
            Console.WriteLine(targets);
        }
    }
}
