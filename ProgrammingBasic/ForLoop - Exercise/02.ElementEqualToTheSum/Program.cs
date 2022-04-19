// See https://aka.ms/new-console-template for more information

var input = Convert.ToInt32(Console.ReadLine());
var bigest = 0;
var sum = 0;
for (int i = 1; i <= input; i++)
{
    var number = Convert.ToInt32(Console.ReadLine());
    sum = sum + number;
    if (bigest < number)
    {
        bigest = number;
    }
}
if (sum == bigest * 2)
{
    Console.WriteLine("Yes");
    Console.WriteLine("Sum = " + bigest);
}
else
{
    Console.WriteLine("No");
    Console.WriteLine("Diff = " + Math.Abs((sum - bigest) - bigest));
}