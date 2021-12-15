using System;
using System.ComponentModel.Design;
using System.Threading.Channels;

namespace _06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            MiddleIndex(text);
        }

        static string MiddleIndex(string text)
        {
            string result = " ";

            if (text.Length % 2 == 0) 
            {
                result = text[text.Length / 2 - 1].ToString();
                Console.Write(result);
                int test = result.Length;
                if (test % 2 != 0)
                {
                    result = text[text.Length / 2].ToString();
                    Console.Write(result);
                }
            }
            else
            {
                result = text[text.Length / 2].ToString();
                Console.Write(result);
            }
            return result;
        }
    }
}
