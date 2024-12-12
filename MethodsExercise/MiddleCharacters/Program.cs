using System;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(GetMiddleCharacters(input));
        }
        static string GetMiddleCharacters(string input)
        {
            if (input.Length % 2 != 0)
            {
                char middleChar = input[(input.Length / 2)];
                string middle = middleChar.ToString();
                return middle;
            }
            else
            {
                char firstMiddleChar = input[(input.Length / 2) - 1];
                string first = firstMiddleChar.ToString();
                char secondMiddleChar = input[(input.Length / 2)];
                string second = secondMiddleChar.ToString();
                string twoChars = first + second;
                return twoChars;
            }
        }
    }
}
