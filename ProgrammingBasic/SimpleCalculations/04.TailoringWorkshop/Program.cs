using System;

namespace SewingWorkshop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfTables = int.Parse(Console.ReadLine());
            double lenghtTable = double.Parse(Console.ReadLine());
            double weightTable = double.Parse(Console.ReadLine());

            double priceRectangular = numOfTables * (lenghtTable + 2 * 0.30) * (weightTable + 2 * 0.30);
            double priceSquare = numOfTables * (lenghtTable / 2) * (lenghtTable / 2);

            double dollarPrice = priceRectangular * 7 + priceSquare * 9;
            double bgnPrice = dollarPrice * 1.85;

            Console.WriteLine($"{dollarPrice:F2} USD");
            Console.WriteLine($"{bgnPrice:F2} BGN");

        }
    }
}
