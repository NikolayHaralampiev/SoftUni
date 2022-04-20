using System;

namespace _07.SmallestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var min = int.MaxValue;
            for (var i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num < min)
                    min = num;
            }
            Console.WriteLine(min);
        }
    }
}
