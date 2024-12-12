using System;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            GetTopNumber(n);
        }
        static void GetTopNumber(int n)
        {
            bool isDivisible = false;
            bool hasOneOdd = false;
            int oddCounter = 0;
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int current = i;
                while (current != 0)
                {
                    int curr = current % 10;
                    if (curr % 2 != 0)
                    {
                        oddCounter++;
                    }
                    sum += curr;
                    current /= 10;
                }
                if (sum % 8 == 0)
                {
                    isDivisible = true;
                }
                if (oddCounter >= 1)
                {
                    hasOneOdd = true;
                }
                if (isDivisible && hasOneOdd)
                {
                    Console.WriteLine(i);
                }
                sum = 0;
                oddCounter = 0;
                isDivisible = false;
                hasOneOdd = false;
            }
        }
    }
}
