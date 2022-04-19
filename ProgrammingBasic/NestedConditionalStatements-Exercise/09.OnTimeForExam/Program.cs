using System;

namespace _09.OnTimeForExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minuteExam = int.Parse(Console.ReadLine());
            int hourArrive = int.Parse(Console.ReadLine());
            int minuteArrive = int.Parse(Console.ReadLine());

            int examTimeMins = hourExam * 60 + minuteExam;
            int arriveMins = hourArrive * 60 + minuteArrive;
            int diffInTimes = Math.Abs(examTimeMins - arriveMins);

            if (examTimeMins == arriveMins || (examTimeMins > arriveMins && diffInTimes <= 30))
            {
                if (diffInTimes != 0)
                {
                    Console.WriteLine("On Time");
                    Console.WriteLine($"{diffInTimes} minutes before the start");
                }
                else
                {
                    Console.WriteLine("On Time");
                }
            }

            else if (examTimeMins > arriveMins && diffInTimes > 30)
            {
                if (diffInTimes < 60)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{diffInTimes} minutes before the start");
                }
                else
                {
                    int minutes = diffInTimes % 60;
                    diffInTimes /= 60;

                    Console.WriteLine("Early");
                    Console.WriteLine($"{diffInTimes}:{minutes:D2} hours before the start");
                }
            }

            else
            {
                if (diffInTimes < 60)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{diffInTimes} minutes after the start");
                }
                else
                {
                    int minutes = diffInTimes % 60;
                    diffInTimes /= 60;

                    Console.WriteLine("Late");
                    Console.WriteLine($"{diffInTimes}:{minutes:D2} hours after the start");
                }
            }
        }
    }
}
