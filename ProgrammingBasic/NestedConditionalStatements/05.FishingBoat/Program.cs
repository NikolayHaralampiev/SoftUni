// See https://aka.ms/new-console-template for more information

//Цената за наем на кораба през пролетта е  3000 лв.
//Цената за наем на кораба през лятото и есента е  4200 лв.
//Цената за наем на кораба през зимата е  2600 лв.

//Ако групата е до 6 човека включително  –  отстъпка от 10%.
//Ако групата е от 7 до 11 човека включително  –  отстъпка от 15%.
//Ако групата е от 12 нагоре  –  отстъпка от 25%. 

double groupBudget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();
int fisherman = int.Parse(Console.ReadLine());

int[] boatPrice = {3000, 4200, 4200, 2600};
double totalCost = 0;

switch (season)
{
    case "Spring":
        if (fisherman <= 6)
        {
            totalCost = boatPrice[0] * 0.9;
            if (fisherman % 2 == 0)
            {
                totalCost *= 0.95;
            }
        }

        if (fisherman >=7 && fisherman <=11)
        {
            totalCost = boatPrice[0] * 0.85;
            if (fisherman % 2 == 0)
            {
                totalCost *= 0.95;
            }
        }

        if (fisherman >=12)
        {
            totalCost = boatPrice[0] * 0.75;
            if (fisherman %2 == 0)
            {
                totalCost *= 0.95;
            }
        }
        break;

    case "Summer":
        if (fisherman <= 6)
        {
            totalCost = boatPrice[1] * 0.9;
            if (fisherman % 2 ==0)
            {
                totalCost *= 0.95;
            }
        }

        if (fisherman >= 7 && fisherman <= 11)
        {
            totalCost = boatPrice[1] * 0.85;
            if (fisherman % 2 == 0)
            {
                totalCost *= 0.95;
            }
        }
        if (fisherman >= 12)
        {
            totalCost = boatPrice[1] * 0.75;
            if (fisherman % 2 == 0)
            {
                totalCost *= 0.95;
            }
        }
        break;

    case "Autumn":
        if (fisherman <= 6)
        {
            totalCost = boatPrice[2] * 0.9;
        }
        if (fisherman >= 7 && fisherman <= 11)
        {
            totalCost = boatPrice[2] * 0.85;
        }
        if (fisherman >= 12)
        {
            totalCost = boatPrice[2] * 0.75;
        }
        break;

    case "Winter":
        if (fisherman <= 6)
        {
            totalCost = boatPrice[3] * 0.9;
            if (fisherman % 2 == 0)
            {
                totalCost *= 0.95;
            }
        }

        if (fisherman >= 7 && fisherman <= 11)
        {
            totalCost = boatPrice[3] * 0.85;
            if (fisherman % 2 == 0)
            {
                totalCost *= 0.95;
            }
        }
        if (fisherman >= 12)
        {
            totalCost = boatPrice[3] * 0.75;
            if (fisherman % 2 == 0)
            {
                totalCost *= 0.95;
            }
        }
        break;
}

if (groupBudget >= totalCost)
{
    Console.WriteLine($"Yes! You have {groupBudget - totalCost:F2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money! You need {totalCost - groupBudget:F2} leva.");
}