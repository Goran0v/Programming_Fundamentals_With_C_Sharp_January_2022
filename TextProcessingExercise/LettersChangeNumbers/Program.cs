using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            decimal sum = 0;

            foreach (var word in words)
            {
                sum += CalculateSingleWordSum(word);
            }

            Console.WriteLine($"{sum:f2}");
        }
        static decimal CalculateSingleWordSum(string word)
        {
            decimal sum = 0;
            char firstLetter = word[0];
            char lastLetter = word[word.Length - 1];
            int num = int.Parse(word.Substring(1, word.Length - 2));

            int firstLetterPositon = GetAlphabeticalPositionOfCharacter(firstLetter);
            int lastLetterPosition = GetAlphabeticalPositionOfCharacter(lastLetter);

            if (char.IsUpper(firstLetter))
            {
                sum = (decimal)num / firstLetterPositon;
            }
            else if (char.IsLower(firstLetter))
            {
                sum = (decimal)num * firstLetterPositon;
            }

            if (char.IsUpper(lastLetter))
            {
                sum -= lastLetterPosition;
            }
            else if (char.IsLower(lastLetter))
            {
                sum += lastLetterPosition;
            }

            return sum;
        }
        static int GetAlphabeticalPositionOfCharacter(char ch)
        {
            if (!char.IsLetter(ch))
            {
                return -1;
            }

            char chCl = Char.ToLowerInvariant(ch);

            return (int)chCl - 96;
        }
    }
}
