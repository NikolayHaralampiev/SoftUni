﻿using System;

namespace NeighbourhoodShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double result = 0;

            if (city == "Sofia")
            {
                if (product == "coffee")
                {
                    result = quantity * 0.50;
                }
                else if (product == "water")
                {
                    result = quantity * 0.80;
                }
                else if (product == "beer")
                {
                    result = quantity * 1.20;
                }
                else if (product == "sweets")
                {
                    result = quantity * 1.45;
                }
                else if (product == "peanuts")
                {
                    result = quantity * 1.60;
                }
            }

            else if (city == "Plovdiv")
            {
                if (product == "coffee")
                {
                    result = quantity * 0.40;
                }
                else if (product == "water")
                {
                    result = quantity * 0.70;
                }
                else if (product == "beer")
                {
                    result = quantity * 1.15;
                }
                else if (product == "sweets")
                {
                    result = quantity * 1.30;
                }
                else if (product == "peanuts")
                {
                    result = quantity * 1.50;
                }
            }

            else if (city == "Varna")
            {

                if (product == "coffee")
                {
                    result = quantity * 0.45;
                }
                else if (product == "water")
                {
                    result = quantity * 0.70;
                }
                else if (product == "beer")
                {
                    result = quantity * 1.10;
                }
                else if (product == "sweets")
                {
                    result = quantity * 1.35;
                }
                else if (product == "peanuts")
                {
                    result = quantity * 1.55;
                }
            }
            Console.WriteLine(result);
        }
    }
}
