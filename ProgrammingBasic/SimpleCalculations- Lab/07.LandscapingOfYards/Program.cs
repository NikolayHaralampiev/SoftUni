using System;

namespace _07.LandscapingOfYards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());
            double priceForYard = meters * 7.61;
            double discount = 0.18 * priceForYard;
            double finalPrice = priceForYard - discount;

            Console.WriteLine($"The final price is: {finalPrice:F2} lv.");
            Console.WriteLine($"The discount is: {discount:F2}");
        }
    }
}
