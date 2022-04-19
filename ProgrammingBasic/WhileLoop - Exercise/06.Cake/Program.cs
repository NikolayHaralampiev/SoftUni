using System;

namespace _06.Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            int sizeOfCake = width * length;
            while (sizeOfCake > 0)
            {
                string piecesCake = Console.ReadLine();
                if (piecesCake == "STOP")
                {
                    break;
                }
                int piecesOfCake = int.Parse(piecesCake);
                sizeOfCake -= piecesOfCake;
            }
            Console.WriteLine(sizeOfCake <= 0 ? $"No more cake left! You need {Math.Abs(sizeOfCake)} pieces more." : $"{sizeOfCake} pieces are left.");
        }
    }
}

