using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(@|#)([a-zA-Z]{3,})(\1)(\1)([a-zA-Z]{3,})(\1)");
            string message = Console.ReadLine();
            List<string[]> words = new List<string[]>();

            MatchCollection matches = regex.Matches(message);
            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }
            foreach (Match match in matches)
            {
                string firstWord = match.Groups[2].Value;
                string secondWord = match.Groups[5].Value;
                string reversed = string.Join("", secondWord.Reverse());
                if (firstWord == reversed)
                {
                    words.Add(new string[] { firstWord, secondWord });
                }
            }

            if (words.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                string[] messages = words.Select(word => $"{word[0]} <=> {word[1]}").ToArray();
                Console.WriteLine($"The mirror words are:");
                Console.WriteLine($"{string.Join(", ", words)}");
            }
        }
    }
}
