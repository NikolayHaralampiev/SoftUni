// See https://aka.ms/new-console-template for more information

//повече от 80 Рози - 10% отстъпка от крайната цена
//повече от 90  Далии - 15% отстъпка от крайната цена
//повече от 80 Лалета - 15% отстъпка от крайната цена
//по-малко от 120 Нарциса - цената се оскъпява с 15%
//по-малко от 80 Гладиоли - цената се оскъпява с 20%

string typeFlowers = Console.ReadLine();
int numberOfFlowers = int.Parse(Console.ReadLine());
double budget = double.Parse(Console.ReadLine());
double price = 0.0;

if (typeFlowers == "Roses")
{
    price = numberOfFlowers * 5;
    if (numberOfFlowers > 80)
    {
        price *= 0.9;
    }
}

if (typeFlowers == "Dahlias")
{
    price = numberOfFlowers * 3.80;
    if (numberOfFlowers > 90)
    {
        price *= 0.85;
    }
}

if (typeFlowers=="Tulips")
{
    price = numberOfFlowers * 2.80;
    if (numberOfFlowers > 80)
    {
        price *= 0.85;
    }
}

if (typeFlowers == "Narcissus")
{
    price = numberOfFlowers * 3;
    if (numberOfFlowers < 120)
    {
        price += (price * 0.15);
    }
}

if (typeFlowers == "Gladiolus")
{
    price = numberOfFlowers * 2.50;
    if (numberOfFlowers < 80)
    {
        price += (price * 0.20);
    }
}

double difference = Math.Abs(budget - price);

if (budget >= price)
{
    Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeFlowers} and {difference:f2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money, you need {difference:f2} leva more.");
}


