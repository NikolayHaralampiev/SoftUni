using System;

namespace _04.Steps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalSteps = 0;

            while (totalSteps < 10000)
            {
                string command = Console.ReadLine();
                if (command == "Going home")
                {
                    totalSteps += int.Parse(Console.ReadLine());
                    break;
                }
                int steps = int.Parse(command);
                totalSteps += steps;
            }
            Console.WriteLine(totalSteps < 10000 ? $"{10000 - totalSteps} more steps to reach goal." : $"Goal reached! Good job!\n{totalSteps - 10000} steps over the goal!");
        }
    }
}
