using System;

namespace PrintAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int sum = 0;
            int br = 0;
            for (int i = start; i <= end; i++)
            {
                sum += i;
                br++;
                Console.Write($" {i}");
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}