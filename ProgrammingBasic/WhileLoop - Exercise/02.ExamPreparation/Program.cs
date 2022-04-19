using System;

namespace _02.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxBadGrades = int.Parse(Console.ReadLine());
            int counterBadGrades = 0;
            int counterAllGrades = 0;
            double sumGrades = 0;
            string taskName = "";
            string lastTask = "";

            while (counterBadGrades < maxBadGrades)
            {
                lastTask = taskName;
                taskName = Console.ReadLine();

                if (taskName == "Enough")
                {
                    Console.WriteLine($"Average score: {(sumGrades / counterAllGrades):F2}");
                    Console.WriteLine($"Number of problems: {counterAllGrades}");
                    Console.WriteLine($"Last problem: {lastTask}");
                    break;
                }
                double taskGrade = double.Parse(Console.ReadLine());

                if (taskGrade <=4)
                {
                    counterBadGrades++;
                }
                sumGrades += taskGrade;
                counterAllGrades++;
            }

            if (taskName != "Enough")
            {
                Console.WriteLine($"You need a break, {maxBadGrades} poor grades.");
            }
        }
    }
}
