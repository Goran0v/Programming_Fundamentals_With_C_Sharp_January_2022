using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"{GetResult(a, b):f2}");
        }
        static long GetFirstFactoriel(int a)
        {
            long factoriel = 1;
            for (int i = 1; i <= a; i++)
            {
                factoriel *= i;
            }
            return factoriel;
        }
        static long GetSecondFactoriel(int b)
        {
            long factoriel = 1;
            for (int i = 1; i <= b; i++)
            {
                factoriel *= i;
            }
            return factoriel;
        }
        static double GetResult(int a, int b)
        {
            double result = (GetFirstFactoriel(a) * 1.0 / GetSecondFactoriel(b));
            return result;
        }
    }
}
