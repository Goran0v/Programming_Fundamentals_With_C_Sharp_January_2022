using System;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b([A-Z][a-z]{1,}) ([A-Z][a-z]{1,})\b";
            string names = Console.ReadLine();
            MatchCollection matched = Regex.Matches(names, regex);

            foreach (var match in matched)
            {
                Console.Write($"{match} ");
            }
            Console.WriteLine();
        }
    }
}