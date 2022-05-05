using System;

namespace _04.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            string[] nums = word.Split(' ');

            for (int j = 0; j < n; j++)
            {
                var temp = nums[0];
                for (var i = 0; i < nums.Length - 1; i++)
                {
                    nums[i] = nums[i + 1];
                }
                nums[nums.Length - 1] = temp;
            }
            Console.WriteLine("{0}", string.Join(" ", nums));
        }
    }
}
