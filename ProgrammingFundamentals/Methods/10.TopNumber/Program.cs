using System;

namespace _10.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (Digits(i) && Odds(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool Digits(int number)
        {
            int sum = 0;
            while (number !=0)
            {
                sum += number % 10;
                number /= 10;
            }

            if (sum % 8 ==0)
            {
                return true;
            }

            return false;
        }

        static bool Odds(int number)
        {
            while (number !=0)
            {
                if ((number%10) %2 !=0)
                {
                    return true;
                }

                number /= 10;
            }

            return false;
        }
    }
}
