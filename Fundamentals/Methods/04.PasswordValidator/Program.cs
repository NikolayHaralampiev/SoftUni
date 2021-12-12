using System;
using System.Linq;
using System.Globalization;
using System.Threading.Channels;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int convert = input.Length;

            bool CheckLenght = Lenght(input);
            bool FinalForBoth = CheckForBoth(input);
            bool CheckDigits = Digits(input);

            if (CheckLenght && FinalForBoth && CheckDigits)
            {
                Console.WriteLine("Password is valid");
            }

            if (!CheckLenght)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!FinalForBoth)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!CheckDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }

        static bool Lenght(string input)
        {
            bool NeededLenght = false;
            if (input.Length <= 10 && input.Length >= 6)
            {
                NeededLenght = true;
            }

            return NeededLenght;
        }

        static bool CheckForBoth(string intput)
        {
            bool LettersAndDigits = false;

            foreach (var item in intput)
            {
                if (char.IsLetterOrDigit(item))
                {
                    LettersAndDigits = true;
                }
                else
                {
                    LettersAndDigits = false;
                    break;
                }
            }
            return LettersAndDigits;
        }

        static bool Digits(string input)
        {
            bool MoreThanTwo = false;
            int count = 0;
            int[] digits = new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            foreach (var item in input)
            {
                if (char.IsDigit(item))
                {
                    count++;
                }
            }

            if (count >= 2)
            {
                MoreThanTwo = true;
            }

            return MoreThanTwo;
        }
    }
}
