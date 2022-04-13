using System;

namespace _06.CharityCampaign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int numOfPastryCook = int.Parse(Console.ReadLine());
            int numOfCakes = int.Parse(Console.ReadLine());
            int numOfWaffles = int.Parse(Console.ReadLine());
            int numOfPancakes = int.Parse(Console.ReadLine());

            int sumOfCakes = numOfCakes * 45;
            double sumOfWaffles = numOfWaffles * 5.80;
            double sumOfPancakes = numOfPancakes * 3.20;

            double sumOfDay = (sumOfCakes + sumOfWaffles + sumOfPancakes) * numOfPastryCook;
            double sumOfCampaign = sumOfDay * days;
            double sumAfterCosts = sumOfCampaign - (sumOfCampaign/8);

            Console.WriteLine($"{sumAfterCosts:F2}");
        }
    }
}
