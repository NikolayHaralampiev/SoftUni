using System;

namespace _08.GraduationPart1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grade = 1;
            double rating = 0;
            double sum = 0;
            int k = 12;
            int s = 0;
            bool a = true;
            if (a == true)
            {
                while (grade <= k)
                {
                    rating = double.Parse(Console.ReadLine());
                    sum += rating;
                    if (rating < 4)
                    {
                        k++;
                        s++;
                    }
                    if (s > 1)
                    {
                        Console.WriteLine($"{name} has been excluded at {grade - s + 1} grade");
                        a = false;
                    }
                    else if (grade - s == 12)
                    {
                        Console.WriteLine($"{name} graduated. Average grade: {sum / k:F2}");
                    }
                    grade++;
                }
            }
        }
    }
}

