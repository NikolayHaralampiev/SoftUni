using System;

namespace _01.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double tripPrice = 0;
            string destination = "";
            string roomType = "";

            if (budget < 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    tripPrice = budget * 0.3;
                }
                else if (season == "winter")
                {
                    tripPrice = budget * 0.7;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    tripPrice = budget * 0.4;
                }
                else if (season == "winter")
                {
                    tripPrice = budget * 0.8;
                }
            }
            else
            {
                destination = "Europe";
                tripPrice = budget * 0.9;
            }

            switch (season)
            {
                case "summer":
                    if (destination == "Europe")
                    {
                        roomType = "Hotel";
                    }
                    else
                    {
                        roomType = "Camp";
                    }
                    break;

                case "winter":
                    roomType = "Hotel";
                    break;
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{roomType} - {tripPrice:F2}");
        }
    }
}
