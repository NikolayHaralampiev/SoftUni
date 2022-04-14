using System;

namespace _06.GodzillaVsKong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double movieBudget = double.Parse(Console.ReadLine());
            int extra = int.Parse(Console.ReadLine());
            double priceCloth = double.Parse(Console.ReadLine());

            double priceDecor = 0.10 * movieBudget;
            double sumClothing = priceCloth * extra;

            if (extra > 150)
            {
                sumClothing = sumClothing - (0.10 * sumClothing);
            }

            double totalMoney = sumClothing + priceDecor;
            double moneyLeft = movieBudget - totalMoney;

            if (totalMoney > movieBudget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard need {moneyLeft:F2} leva more.");
            }
            else if (totalMoney < movieBudget)
            {
                Console.WriteLine("Action");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:F2} leva left.");
            }
        }
    }
}
