using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"(#|@)([A-Za-z]{3,})(\1)(\1)([A-Za-z]{3,})(\1)";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);
            int counter = 0;
            List<string> validPairs = new List<string>();
            foreach (Match match in matches)
            {
                string firstWord = match.Groups[2].Value;
                string secondWord = match.Groups[5].Value;
                string reversed = string.Join("", firstWord.Reverse());
                if (reversed == secondWord)
                {
                    counter++;
                    string pairs = firstWord + " " + "<=>" + " " + secondWord;
                    validPairs.Add(pairs);
                }
            }

            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }

            if (counter == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", validPairs));
            }
        }
    }
}
