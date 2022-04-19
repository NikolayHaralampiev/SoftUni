using System;

namespace _04.ConvertorForMeasuringUnits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numberForConverting = double.Parse(Console.ReadLine());
            string inputUnit = Console.ReadLine();
            string outputUnit = Console.ReadLine();
            double result = 0;

            if (inputUnit == "m")
            {
                result = numberForConverting * 1000;
            }
            else if (inputUnit == "cm")
            {
                result = numberForConverting * 10;
            }
            else if (inputUnit == "mm")
            {
                result = numberForConverting;
            }

            if (outputUnit == "m")
            {
                numberForConverting = result / 1000;
            }
            else if (outputUnit == "cm")
            {
                numberForConverting = result /10;
            }
            else if (outputUnit == "m")
            {
                numberForConverting = result;
            }

            Console.WriteLine($"{numberForConverting:F3}");
        }
    }
}
