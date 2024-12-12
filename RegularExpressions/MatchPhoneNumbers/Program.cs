using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchPhoneNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\+359( |-)2\1\d{3}\1\d{4}\b";
            string names = Console.ReadLine();
            MatchCollection matched = Regex.Matches(names, regex);

            string[] matches = Regex.Matches(names, regex).Select(x => x.Value).ToArray();

            Console.WriteLine(string.Join(", ", matches));
        }
    }
}
