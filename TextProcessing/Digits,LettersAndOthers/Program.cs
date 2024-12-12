using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Digits_LettersAndOthers
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder letters = new StringBuilder();
            StringBuilder numbers = new StringBuilder();
            StringBuilder others = new StringBuilder();
            string text = Console.ReadLine();

            foreach (var word in text)
            {
                if (char.IsLetter(word))
                {
                    letters.Append(word);
                }
                else if (char.IsDigit(word))
                {
                    numbers.Append(word);
                }
                else
                {
                    others.Append(word);
                }
            }

            Console.WriteLine(numbers);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}
