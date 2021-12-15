using System;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());

            var result = Fact1(first) / Fact2(second);
            Console.WriteLine($"{result:f2}");
        }

        static double Fact1(double first)
        {
            double fac1 = 1;
            for (int i = 1; i <= first; i++)
            {
                fac1 *= i;
            }

            return fac1;
        }

        static double Fact2(double second)
        {
            double fac2 = 1;
            for (int i = 1; i <= second; i++)
            {
                fac2 *= i;
            }

            return fac2;
        }
    }

}
