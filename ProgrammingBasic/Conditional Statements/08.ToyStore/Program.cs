using System;

namespace _08.ToyStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceTrip = double.Parse(Console.ReadLine());
            int puzzels = int.Parse(Console.ReadLine());
            int doll = int.Parse(Console.ReadLine());
            int teddyBears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double pricePuzzels = 2.60 * puzzels;
            double priceDoll = 3 * doll;
            double priceTeddyBears = 4.10 * teddyBears;
            double priceMinions = 8.20 * minions;
            double priceTrucks = 2 * trucks;

            double totalprice = pricePuzzels + priceDoll + priceTeddyBears + priceMinions + priceTrucks;
            int quantity = puzzels + doll + teddyBears + minions + trucks;

            if (quantity >= 50)
            {
                totalprice = 0.75 * totalprice;
            }

            var rent = 0.10 * totalprice;
            totalprice = totalprice - rent;

            if (totalprice >= priceTrip)
            {
                var moneyLeft = totalprice - priceTrip;
                Console.WriteLine($"Yes! {moneyLeft:F2} lv left.");
            }
            else
            {
                var moneyLack = priceTrip - totalprice;
                Console.WriteLine($"Not enough money! {moneyLack:F2} lv needed.");
            }

        }
    }
}
