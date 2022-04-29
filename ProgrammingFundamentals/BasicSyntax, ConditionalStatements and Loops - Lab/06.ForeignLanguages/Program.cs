using System;

namespace ForeignLanguages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string countryName = Console.ReadLine();

            switch (countryName)
            {
                case "USA":
                    Console.WriteLine("English");
                    break;
                case "Spain" or "Argentina" or "Mexico":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
