using System;

namespace SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int a = 1;

            for (int i = 1; i <= n; i++)
            {
                sum += a;
                Console.WriteLine(a);
                a += 2;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
