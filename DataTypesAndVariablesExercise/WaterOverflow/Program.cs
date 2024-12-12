using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int currentLiters = 0;

            for (int i = 1; i <= n; i++)
            {
                currentLiters = int.Parse(Console.ReadLine());
                sum += currentLiters;
                if (sum > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sum -= currentLiters;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
