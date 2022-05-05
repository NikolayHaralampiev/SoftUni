using System;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroups = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double price = 0;

            if (typeOfGroups == "Students")
            {
                if (dayOfWeek == "Friday")
                {
                    price = 8.45;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = 9.80;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = 10.46;
                }
            }
            else if (typeOfGroups == "Business")
            {
                if (dayOfWeek == "Friday")
                {
                    price = 10.90;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = 15.60;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = 16;
                }
            }
            else if (typeOfGroups == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    price = 15;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = 20;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = 22.50;
                }
            }

            double totalPrice = price * countOfPeople;

            if (typeOfGroups == "Students" && countOfPeople >= 30)
            {
                totalPrice *= 0.85;
            }
            else if (typeOfGroups == "Business" && countOfPeople >= 100)
            {
                totalPrice = totalPrice * (countOfPeople - 10);
            }
            else if (typeOfGroups == "Regular")
            {
                totalPrice -= totalPrice * 0.05;
            }

            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
