using System;
using System.Linq;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            GetPalindrome(numbers);
        }
        static void GetPalindrome(string numbers)
        {
            int counter = 0;
            int newCount = 0;
            while (numbers != "END")
            {
                int current = int.Parse(numbers);
                char[] charArr = numbers.ToCharArray();
                int[] reverse = new int[charArr.Length];
                for (int i = 0; i < charArr.Length; i++)
                {
                    reverse[i] = Convert.ToInt32(charArr[i].ToString());
                }
                while (current != 0)
                {
                    if (current % 10 == reverse[0 + counter])
                    {
                        newCount++;
                    }
                    current /= 10;
                    counter++;
                }
                
                if (newCount == reverse.Length)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                counter = 0;
                newCount = 0;
                numbers = Console.ReadLine();
            }
            
        }
    }
}
