using System;

namespace _10.SkiHoliday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string rating = Console.ReadLine();

            double finalPrice = 0.0;
            double price = 0;

            switch (typeOfRoom)
            {
                case "room for one person":
                    price = 18;
                    break;
                case "apartament":
                    price = 25;
                    if (days < 10)
                    {
                        price *= 70;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        price *= 0.65;
                    }
                    else if (days > 15)
                    {
                        price *= 0.50;
                    }
                    break;

                case "president apartment":
                    price = 35;
                    if (days < 10)
                    {
                        price *= 0.90;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        price *= 0.85;
                    }
                    else if (days > 15)
                    {
                        price *= 0.80;
                    }
                    break;
            }
            finalPrice = (days - 1) * price;

            if (rating == "positive")
            {
                finalPrice = finalPrice + (finalPrice * 0.25);
            }
            else
            {
                finalPrice = finalPrice - (finalPrice * 0.10);
            }

            Console.WriteLine($"{finalPrice:F2}");
        }
    }
}
