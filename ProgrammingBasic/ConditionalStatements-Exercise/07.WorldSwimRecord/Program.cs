using System;

namespace _07.WorldSwimRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordTime = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeInSec = double.Parse(Console.ReadLine());

            double totalSec = distance * timeInSec;
            double delaySec = Math.Floor(distance/(double)15);
            delaySec *= 12.5;

            double totalTime = totalSec + delaySec;

            if (totalSec < recordTime)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {totalTime - recordTime:F2} seconds slower.");
            }
        }
    }
}
