using System;

namespace _10.Volleyball
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string leapOrNot = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int weekendsHome = int.Parse(Console.ReadLine());

            double playsInSofia = (48 - weekendsHome) * 0.75 + ((holidays * 2) * 1.00 / 3);
            double playsInHomeTown = weekendsHome * 1.00;

            Console.WriteLine(leapOrNot == "leap" ? $"{Math.Floor((playsInHomeTown + playsInSofia) * 1.15)}" : $"{Math.Floor((playsInHomeTown + playsInSofia))}");
        }
    }
}
