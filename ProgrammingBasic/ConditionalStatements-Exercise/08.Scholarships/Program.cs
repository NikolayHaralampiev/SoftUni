using System;

namespace _08.Scholarships
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());

            double socialScholarship = Math.Floor(minSalary * 0.35);
            double exellentScolarship = Math.Floor(averageGrade * 25);

            if (income <= minSalary && averageGrade >= 5.5 && exellentScolarship >= socialScholarship)
            {
                Console.WriteLine($"You get a scholarship for excellent results {exellentScolarship} BGN");
            }
            else if (income <= minSalary && averageGrade >= 5.5 && exellentScolarship < socialScholarship)
            {
                Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
            }
            else if (income > minSalary && averageGrade >= 5.5)
            {
                Console.WriteLine($"You get a scholarship for excellent results {exellentScolarship} BGN");
            }
            else if (income <= minSalary && averageGrade > 4.5)
            {
                Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
