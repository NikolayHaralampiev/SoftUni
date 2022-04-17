using System;

namespace FaceOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                int side = int.Parse(Console.ReadLine());
                Console.WriteLine($"{side * side:F3}");
            }
            else if (figure == "rectangle")
            {
                double length1 = double.Parse(Console.ReadLine());
                double length2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"{length1 * length2:F3}");
            }
            else if(figure == "circle")
            {
                int radius = int.Parse(Console.ReadLine());
                Console.WriteLine($"{Math.PI * radius * radius:F3}");
            }
            else if (figure == "triangle")
            {
                double lenght1 = int.Parse(Console.ReadLine());
                double lenght2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"{(lenght1 * lenght2)/2:F3}");
            }

           
        }
    }
}
