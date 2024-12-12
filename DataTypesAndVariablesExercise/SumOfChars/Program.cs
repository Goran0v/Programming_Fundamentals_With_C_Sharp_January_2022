using System;

namespace SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte numOfLines = sbyte.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= numOfLines; i++)
            {
                char letters = char.Parse(Console.ReadLine());
                sum += letters;
                //letters = (char)numOfLines;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}