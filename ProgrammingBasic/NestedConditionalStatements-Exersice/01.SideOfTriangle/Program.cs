// See https://aka.ms/new-console-template for more information

double x1 = double.Parse(Console.ReadLine());
double y1 = double.Parse(Console.ReadLine());
double x2 = double.Parse(Console.ReadLine());
double y2 = double.Parse(Console.ReadLine());
double x = double.Parse(Console.ReadLine());
double y = double.Parse(Console.ReadLine());


bool firstCondition = (x == x1 || x == x2) && (y >= y1 && y <= y2);
bool secondCondition = (y == y1 || y == y2) && (x >= x1 && x <= x2);

if (firstCondition || secondCondition)
{
    Console.WriteLine("Border");
}
else
{
    Console.WriteLine("Inside / Outside");
}