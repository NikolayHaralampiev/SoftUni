using System;

namespace GuessingNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppInfo();
            Greet();

            while (true)
            {
                Random random = new Random();
                int correctNumber = random.Next(1, 10);
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10!");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out guess))
                    {
                        PrintColor(ConsoleColor.Red, "Please type  an actual number!");
                        continue;
                    }
                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        PrintColor(ConsoleColor.Red, "Wrong number, please try again!");
                    }
                }

                PrintColor(ConsoleColor.Green, "CORRECT! U guessed it!!! :)");
                Console.WriteLine("Wanna play again [Y] or [N]");

                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }

            static void AppInfo()
            {
                string appName = "Number Guesser";
                string appAuthor = "Nikolay Haralampiev";

                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine($"{appName} by {appAuthor}");

                Console.ResetColor();
            }

            static void Greet()
            {
                Console.WriteLine("What is your name?");

                string name = Console.ReadLine();

                Console.WriteLine($"Hello {name} let`s play a game... :)");
            }

            static void PrintColor(ConsoleColor color, string text)
            {
                Console.ForegroundColor = color;
                Console.WriteLine(text);
                Console.ResetColor();
            }
        }
    }
}
