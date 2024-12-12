using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder newText = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                char current = text[i];
                char newChar = (char)(current + 3);
                newText.Append(newChar);
            }

            Console.WriteLine(newText);
        }
    }
}
