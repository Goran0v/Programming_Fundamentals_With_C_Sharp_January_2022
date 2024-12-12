using System;
using System.Linq;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Console.WriteLine(GetVowels(word));
        }
        static int GetVowels(string word)
        {
            int counter = 0;
            char[] vowels = new char[] { 'a', 'e', 'o', 'u', 'i', 'A', 'E', 'O', 'U', 'I' };
            foreach (char ch in word)
            {
                if (vowels.Contains(ch))
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
