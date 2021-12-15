// See https://aka.ms/new-console-template for more information

int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());
string print = string.Empty;

if (minutes < 45)
{
    print = $"{hours}:{minutes + 15:d2}";
}
else if (hours != 23 && minutes >= 45)
{
    print = $"{hours + 1}:{((minutes + 15) - 60):d2}";
}
else if (hours == 23 && minutes >= 45)
{
    hours = 0;
    print = $"{hours}:{((minutes + 15) - 60):d2}";
}

Console.WriteLine(print);