using System;

namespace _10.Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int widthFreeSpace = int.Parse(Console.ReadLine());
            int lengthFreeSpace = int.Parse(Console.ReadLine());
            int heightFreeSpace = int.Parse(Console.ReadLine());

            double freeSpace = widthFreeSpace * lengthFreeSpace * heightFreeSpace;
            string boxesCount = Console.ReadLine();

            while (freeSpace > 0 && boxesCount != "Done")
            {
                double boxesCountNum = double.Parse(boxesCount);
                freeSpace -= boxesCountNum;
                boxesCount = Console.ReadLine();
            }

            Console.WriteLine(freeSpace <= 0 ? $"No more free space! You need {Math.Abs(freeSpace)} Cubic meters more." : $"{freeSpace} Cubic meters left.");
        }
    }
}
