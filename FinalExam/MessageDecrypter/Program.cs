using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MessageDecrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfInputs = int.Parse(Console.ReadLine());
            string pattern = @"\B(\$|\%)([A-Z]{1}[a-z]{2,})(\1)(:)( )(\[)(\d+)(\])(\|)(\6)(\d+)(\8)(\9)(\6)(\d+)(\8)(\9)\B";
            bool checker = false;
            int counter = 0;
            Regex regex = new Regex(pattern);
            for (int i = 0; i < numOfInputs; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == '|')
                    {
                        counter++;
                    }
                }
                if (counter == 3)
                {
                    checker = true;
                }
                if (regex.IsMatch(input) && checker)
                {
                    Match match = regex.Match(input);
                    string tag = match.Groups[2].Value;
                    int firstLetter = int.Parse(match.Groups[7].Value);
                    char a = (char)(firstLetter);
                    int secondLetter = int.Parse(match.Groups[11].Value);
                    char b = (char)(secondLetter);
                    int thirdLetter = int.Parse(match.Groups[15].Value);
                    char c = (char)(thirdLetter);
                    Console.WriteLine($"{tag}: {a}{b}{c}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
                checker = false;
                counter = 0;
            }
        }
    }
}
