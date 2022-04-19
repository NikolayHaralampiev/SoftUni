using System;

namespace _10.EvenOddAmount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int even = 0;
            int odd = 0;

            for (int i = 0; i < numbers; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    even += num;
                }
                else
                {
                    odd += num;
                }
            }
            int sum = Math.Abs(even - odd);
            Console.WriteLine(even == odd ? $"Yes\nSum={even}" : $"No\nDiff={sum}");
        }
    }
}
