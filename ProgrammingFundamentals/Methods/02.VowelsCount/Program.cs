using System;
using System.Linq;
using System.Net.Http;
using Microsoft.VisualBasic;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();

            Console.WriteLine(GetVowels(word));
        }

        static int GetVowels(string word)
        {
            char[] volews = new char[] {'a', 'e', 'i', 'o', 'u'};
            int total = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (volews.Contains(word[i]))
                {
                    total++;
                }
            }

            return total;
        }
    }
}
