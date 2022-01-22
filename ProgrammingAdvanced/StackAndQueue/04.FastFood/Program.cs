using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantitFood = int.Parse(Console.ReadLine());
            List<int> orders = Console.ReadLine().Split().Select(int.Parse).ToList();
            Queue<int> line = new Queue<int>(orders);

            Console.WriteLine(line.Max());

            while (line.Count > 0)
            {
                if (quantitFood >= line.Peek())
                {
                    quantitFood -= line.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ",line)}");
                    return;
                }
            }

            Console.WriteLine("Orders complete");
        }
    }
}
