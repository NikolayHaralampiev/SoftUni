using System;

namespace _02.OperationsBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double N1 = double.Parse(Console.ReadLine());
            double N2 = double.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());

            double result = 0;

            switch (symbol)
            {
                case '+':
                    result = N1 + N2;
                    break;

                    case '-':
                    result = N1 - N2;
                    break;

                    case '*':
                    result = N1 * N2;
                    break;

                    case '/':
                    if (N2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }
                    else
                    {
                        result = N1 * 1.00 / N2;
                        Console.WriteLine($"{N1} / {N2} = {result:F2}");
                    }
                    break;

                    case '%':
                    if (N2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }
                    else
                    {
                        result = N1 % N2;
                        Console.WriteLine($"{N1} % {N2} = {result:F2}");
                    }
                    break;
            }

            double even = result % 2;
            if (even == 0)
            {
                if (symbol == '+')
                {
                    Console.WriteLine($"{N1} + {N2} = {result} - even");
                }
                else if (symbol == '-')
                {
                    Console.WriteLine($"{N1} - {N2} = {result} - even");
                }
                else if (symbol == '*')
                {
                    Console.WriteLine($"{N1} * {N2} = {result} - even");
                }
            }
            else
            {
                if (symbol == '+')
                {
                    Console.WriteLine($"{N1} + {N2} = {result} - odd");
                }
                else if (symbol == '-')
                {
                    Console.WriteLine($"{N1} - {N2} = {result} - odd");
                }
                else if (symbol == '*')
                {
                    Console.WriteLine($"{N1} * {N2} = {result} - odd");
                }
            }
        }
    }
}
