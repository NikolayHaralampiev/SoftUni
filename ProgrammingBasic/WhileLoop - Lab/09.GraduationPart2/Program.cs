using System;

namespace _09.GraduationPart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int counter = 0;
            double avaragegerades = 0.00;

            bool isexcluded = false;
            int excluded = 0;

            while (counter < 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade < 4)
                {
                    excluded++;
                }
                else if (grade >= 4)
                {
                    avaragegerades += grade;

                    counter++;

                }
                if (excluded >= 2)
                {
                    counter += 1;
                    isexcluded = true;
                    break;
                }
            }
            double sum = avaragegerades / counter;

            if (isexcluded == false)
                Console.WriteLine($" {name} graduated. Average grade: {sum:f2}");
            else
            {
                Console.WriteLine($"{name} has been excluded at {counter} grade");
            }
        }

    }

}
