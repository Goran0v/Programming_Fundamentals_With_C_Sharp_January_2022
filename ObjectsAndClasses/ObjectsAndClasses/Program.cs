using System;
using System.Linq;
using System.Collections.Generic;

namespace ObjectsAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Random random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int randomINdex = random.Next(0, words.Length);
                string currentWord = words[i];
                words[i] = words[randomINdex];
                words[randomINdex] = currentWord;
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}