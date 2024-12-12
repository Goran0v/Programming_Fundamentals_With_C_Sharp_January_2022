using System;
using System.Linq;
using System.Collections.Generic;

namespace WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> synonyms = new Dictionary<string, List<string>>();
            for (int i = 1; i <= n; i++)
            {
                string currentWord = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (synonyms.ContainsKey(currentWord))
                {
                    synonyms[currentWord].Add(synonym);
                }
                else
                {
                    List<string> newSynonyms = new List<string>();
                    newSynonyms.Add(synonym);
                    synonyms.Add(currentWord, newSynonyms);
                }
            }

            foreach (var synonym in synonyms)
            {
                Console.WriteLine($"{synonym.Key} - {string.Join(", ", synonym.Value)}");
            }
        }
    }
}