using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char newLetter;
            StringBuilder newInput = new StringBuilder();

            for (int i = 0; i < input.Length - 1; i++)
            {
                newLetter = input[i];
                if (newLetter != input[i + 1])
                {
                    newInput.Append(newLetter);
                }
            }

            newInput.Append(input[input.Length - 1]);
            Console.WriteLine(newInput);
        }
    }
}
