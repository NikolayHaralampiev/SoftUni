using System;
using System.Numerics;

namespace _11.Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int snowball = int.Parse(Console.ReadLine());
            BigInteger bigestValue = 0;

            int largestSnow = 0;
            int largestTime = 0;
            int largestQuality = 0;

            for (int i = 1; i <= snowball; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());    

                BigInteger currentValue = BigInteger.Pow((snow / time), quality);

                if (currentValue > bigestValue)
                {
                    bigestValue = currentValue;
                    largestSnow = snow;
                    largestTime = time;
                    largestQuality = quality;
                }
            }

            Console.WriteLine($"{largestSnow} : {largestTime} = {bigestValue} ({largestQuality})");
        }
    }
}
