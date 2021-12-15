// See https://aka.ms/new-console-template for more information

double num = double.Parse(Console.ReadLine());
string input = Console.ReadLine();
string output = Console.ReadLine();

double mm =0;

if (input=="m")
{
    mm = num * 1000;
}
else if (input=="cm")
{
    mm = num * 10;
}
else if (input=="mm")
{
    mm = num;
}

if (output == "m")
{
    num = mm / 1000;
}
else if (output=="cm")
{
    num = mm / 10;
}
else if (output=="mm")
{
    num = mm;
}

Console.WriteLine($"{num:F3}");