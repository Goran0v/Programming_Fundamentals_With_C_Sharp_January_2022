using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string word1 = arr[0];
            string word2 = arr[1];
            int totalSum = 0;
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < Math.Max(word1.Length, word2.Length); i++)
            {
                if (i <= word1.Length - 1 && i <= word2.Length - 1)
                {
                    totalSum += word1[i] * word2[i];
                    continue;
                }
                else if (word1.Length > word2.Length)
                {
                    for (int j = i; j < word1.Length; j++)
                    {
                        sum1 += word1[j];
                    }
                    break;
                }
                else if (word2.Length > word1.Length)
                {
                    for (int j = i; j < word2.Length; j++)
                    {
                        sum2 += word2[j];
                    }
                    break;
                }
            }

            totalSum += sum1 + sum2;
            Console.WriteLine(totalSum);
        }
    }
}
