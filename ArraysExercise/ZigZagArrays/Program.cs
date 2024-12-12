using System;
using System.Linq;

namespace ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arrayOne = new int[n];
            int[] arrayTwo = new int[n];

            for (int i = 1; i <= n; i++)
            {
                int[] current = Console.ReadLine()
                        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse).ToArray();
                int firstNumber = current[0];
                int secondNumber = current[1];

                if (i % 2 != 0)
                {
                    arrayOne[i - 1] = firstNumber;
                    arrayTwo[i - 1] = secondNumber;
                }
                else
                {
                    arrayOne[i - 1] = secondNumber;
                    arrayTwo[i - 1] = firstNumber;
                }
            }
            Console.WriteLine(string.Join(" ", arrayOne));
            Console.WriteLine(string.Join(" ", arrayTwo));
        }
    }
}
