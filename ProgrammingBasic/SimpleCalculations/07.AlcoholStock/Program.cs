using System;

namespace _07.AlcoholStock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceWhiskey = double.Parse(Console.ReadLine());
            double quantityBeer = double.Parse(Console.ReadLine());
            double quantityWine = double.Parse(Console.ReadLine());
            double quantityRakia = double.Parse(Console.ReadLine());
            double quantityWhiskey = double.Parse(Console.ReadLine());

            double rakiaPrice = priceWhiskey / 2;
            double winePrice = rakiaPrice - (0.4 * rakiaPrice);
            double beerPrice = rakiaPrice - (0.8 * rakiaPrice);

            double sumRakia = quantityRakia * rakiaPrice;
            double sumWine = quantityWine * winePrice;
            double sumBeer = quantityBeer * beerPrice;
            double sumWhiskey = quantityWhiskey * priceWhiskey;

            Console.WriteLine($"{sumRakia + sumWine + sumBeer + sumWhiskey:F2}");

        }
    }
}
