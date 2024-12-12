using System;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultipleOfEvenAndOdds(input));
        }
        static int GetMultipleOfEvenAndOdds(int input)
        {
            int sumOfEven = 0;
            int sumOfOdd = 0;
            while (input != 0)
            {
                int current = input % 10;
                if (current % 2 == 0)
                {
                    sumOfEven += Math.Abs(current);
                }
                else
                {
                    sumOfOdd += Math.Abs(current);
                }
                input /= 10;
            }
            int result = sumOfEven * sumOfOdd;
            return result;
        }
    }
}
