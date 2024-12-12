using System;
using System.Linq;

namespace EvenAndOddSubstractions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int evenSum = 0;
            int oddSum = 0;
            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    evenSum += item;
                }
                else
                {
                    oddSum += item;
                }
            }
            int result = evenSum - oddSum;
            Console.WriteLine($"{result}");
        }
    }
}
