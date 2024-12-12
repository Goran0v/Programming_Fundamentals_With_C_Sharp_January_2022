using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder outputText = new StringBuilder();
            int bombPower = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char current = input[i];
                if (current == '>')
                {
                    int bombsToExplode = GetCharacterToIntValue(input[i + 1]);
                    outputText.Append(current);
                    bombPower += bombsToExplode;
                }
                else
                {
                    if (bombPower > 0)
                    {
                        bombPower--;
                    }
                    else
                    {
                        outputText.Append(current);
                    }
                }
            }

            Console.WriteLine(outputText.ToString());
        }
        static int GetCharacterToIntValue(char ch)
        {
            return (int)ch - '0';
        }
    }
}
