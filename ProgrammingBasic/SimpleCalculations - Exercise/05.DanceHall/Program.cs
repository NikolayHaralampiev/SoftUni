using System;

namespace _05.DanceHall
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double lenghtHall = double.Parse(Console.ReadLine());
           double weightHall = double.Parse(Console.ReadLine());
           double sideWardrobe = double.Parse(Console.ReadLine());

            double sizeHall = (lenghtHall * 100) * (weightHall * 100);
            double sizeWardrobe = (sideWardrobe * 100) * (sideWardrobe * 100);
            double sizeBench = (sizeHall / 10);
            double freeSpace = (sizeHall - sizeWardrobe - sizeBench);
            double numOfDancers = (freeSpace / (40 + 7000));

            Console.WriteLine(Math.Floor(numOfDancers));
        }
    }
}
