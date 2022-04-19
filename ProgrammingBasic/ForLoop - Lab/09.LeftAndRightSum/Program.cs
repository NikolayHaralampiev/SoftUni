using System;

namespace _09.LeftAndRightSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < 2 * num; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i < num)
                {
                    leftSum += number;
                }
                else
                {
                    rightSum += number;
                }
            }
            int diff = Math.Abs(leftSum - rightSum);
            Console.WriteLine(leftSum == rightSum ? $"Yes, sum = {leftSum}" : $"No, diff {diff}");
        }
    }
}
