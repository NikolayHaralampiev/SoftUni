using System;

namespace _08.Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double capacity = length * width * height;
            double litres = capacity * 0.001;
            double percents = percent * 0.01;
            double litresWeNeed = litres * (1-percents);

            Console.WriteLine($"{litresWeNeed:F3}");
            
        }
    }
}
