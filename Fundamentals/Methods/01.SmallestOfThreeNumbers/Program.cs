using System;

namespace SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            SmallestNumber(num1,num2,num3);
        }

        static int SmallestNumber(int num1, int num2, int num3)
        {
            if (num1 < num2)
            {
                if (num1 < num3)
                {
                    Console.WriteLine(num1);
                    return num1;
                }
                else
                {
                    Console.WriteLine(num3);
                    return num3;

                }
            }

            if (num2 < num3)
            {
                Console.WriteLine(num2);
                return num2;
            }
            else
            {
                Console.WriteLine(num3);
            }

            return num1;
        }
    }
}
