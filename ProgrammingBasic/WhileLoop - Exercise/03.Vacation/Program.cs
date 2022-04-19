using System;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());
            int daysCounter = 0;
            int spendingCounter = 0;

            while (availableMoney < neededMoney && spendingCounter < 5)
            {
                string command = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                daysCounter++;

                if (command == "save")
                {
                    availableMoney += money;
                    spendingCounter += 1;
                }
                else if (command == "spend")
                {
                    availableMoney -= money;
                    spendingCounter += 1;

                    if (availableMoney < 0)
                    {
                        availableMoney = 0;
                    }
                }
            }

            if (spendingCounter == 5)
            {
                Console.WriteLine("You can`t save the money.");
                Console.WriteLine(daysCounter);
            }
            if (availableMoney >= neededMoney)
            {
                Console.WriteLine($"You save the money for {daysCounter} days.");
            }
        }
    }
}
