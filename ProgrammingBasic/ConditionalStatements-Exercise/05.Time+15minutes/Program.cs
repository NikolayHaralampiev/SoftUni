using System;

namespace _05.Time_15minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int timeInMinutes = (hours * 60) + minutes;
            int time15 = timeInMinutes + 15;
            int hoursNew = time15 / 60;
            int minutesNew = time15 % 60;


            if (hoursNew >= 24)
            {
                hoursNew = hoursNew - 24;
            }
            if (minutesNew < 10)
            {
                Console.WriteLine($"{hoursNew}:0{minutesNew}");
            }
            else
            {
                Console.WriteLine($"{hoursNew}:{minutesNew}");
            }
        }
    }
}
