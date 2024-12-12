using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int currNumber = 0;
            int n = number;
            int factoriel = 1;
            int sum = 0;
            while (n != 0)
            {
                currNumber = n % 10;
                for (int i = 1; i <= currNumber; i++)
                {
                    factoriel *= i;
                }
                sum += factoriel;
                factoriel = 1;
                n /= 10;
            }
            if (number == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
