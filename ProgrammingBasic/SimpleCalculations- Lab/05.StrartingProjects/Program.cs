using System;

namespace _05.StrartingProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int numberOfProjects = int.Parse(Console.ReadLine());
            int hours = numberOfProjects * 3;

            Console.WriteLine($"The architect {name} will need {hours} hours to complete {numberOfProjects} project/s.");



        }
    }
}
