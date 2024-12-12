using System;

namespace BitwiseOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int counterForZero = 0;
            int counterForOne = 0;
            while (n != 0)
            {
                if (n % 2 == 0)
                {
                    counterForZero++;
                }
                else if (n % 2 == 1)
                {
                    counterForOne++;
                }
                n /= 10;
            }

            if (b == 0)
            {
                Console.WriteLine(counterForZero);
            }
            else
            {
                Console.WriteLine(counterForOne);
            }
        }
    }
}
