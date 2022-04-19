using System;

namespace _04.FromInchToCm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double inch = num * 2.54;

            Console.WriteLine(inch);
        }
    }
}
