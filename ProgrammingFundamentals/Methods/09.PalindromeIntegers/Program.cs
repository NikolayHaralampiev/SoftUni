using System;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            //int num = 0;
            Palindrome(command);
        }

        static void Palindrome(string command)
        {
            string reverse = String.Empty;

            while (command != "END")
            {
                for (int i = command.Length -1; i >=0; i--)
                {
                    reverse += command[i];
                }

                if (reverse == command)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }

                command = Console.ReadLine();
                reverse = String.Empty;
            }
        }
    }
}
