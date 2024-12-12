using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace TextProcessingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            int counter = 0;

            foreach (var word in arr)
            {
                if (word.Length > 3 && word.Length < 16)
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (!char.IsDigit(word[i]) && !char.IsLetter(word[i]) && word[i] != '-' && word[i] != '_')
                        {
                            counter++;
                        }
                    }
                    if (counter == 0)
                    {
                        Console.WriteLine(word);
                    }
                    counter = 0;
                }
            }
        }
    }
}
