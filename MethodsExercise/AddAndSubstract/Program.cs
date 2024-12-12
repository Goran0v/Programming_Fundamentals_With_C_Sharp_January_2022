using System;

namespace AddAndSubstract
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(GetSubstractionOfTwo(a, b, c));
        }
        static int GetSumOfTwoFirst(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        static int GetSubstractionOfTwo(int a, int b, int c)
        {
            int sub = GetSumOfTwoFirst(a, b) - c;
            return sub;
        }
    }
}
