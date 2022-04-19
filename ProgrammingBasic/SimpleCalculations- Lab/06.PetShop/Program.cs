using System;

namespace _06.PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfDogs = int.Parse(Console.ReadLine());
            int numOfOtherAnimals = int.Parse(Console.ReadLine());
            double priceDogs = numOfDogs * 2.50;
            int priceOther = numOfOtherAnimals * 4;
            double finalPrice = priceDogs + priceOther;


            Console.WriteLine($"{finalPrice:F2} lv.");
        }
    }
}
