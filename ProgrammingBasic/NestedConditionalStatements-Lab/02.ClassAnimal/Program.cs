using System;

namespace _02.ClassAnimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();

            switch (animal)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;

                case "snake":
                case "tortoise":
                case "crocodile":
                    Console.WriteLine("reptile");
                    break;

                case "cat":
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
