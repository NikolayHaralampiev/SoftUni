using System;

namespace _05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            for (int i = 0; i < 4; i++)
            {
                string inputPass = Console.ReadLine();

                if (inputPass == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }

                if (i == 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }

                if (inputPass != password)
                {
                    Console.WriteLine($"Incorrect password. Try again.");
                }
            }
        }
    }
}
