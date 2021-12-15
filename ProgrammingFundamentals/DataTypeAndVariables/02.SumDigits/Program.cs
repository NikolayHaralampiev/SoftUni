using System;

namespace _02.SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int numToSum = int.Parse(Console.ReadLine());
            int finalSum = 0;

            while (numToSum !=0)
            {
                int lastDigit = numToSum % 10;
                finalSum += lastDigit;
                numToSum /= 10;
            }

            Console.WriteLine(finalSum);
        }
    }
}
