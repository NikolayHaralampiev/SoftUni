using System;

namespace Exercise__01.IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int divideNumber = int.Parse(Console.ReadLine());
            int multiplyNumber = int.Parse(Console.ReadLine());

            int sumNums = firstNumber + secondNumber;
            int division = sumNums / divideNumber;
            int multiplication = division * multiplyNumber;

            Console.WriteLine(multiplication);
        }
    }
}
