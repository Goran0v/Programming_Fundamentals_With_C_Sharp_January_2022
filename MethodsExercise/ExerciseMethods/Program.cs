using System;

namespace ExerciseMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(FindTheSmallest(a, b, c));
        }
        static int FindTheSmallest(int a, int b, int c)
        {
            int min = int.MaxValue;
            if (a <= b && a <= c)
            {
                min = a;
            }
            if (b <= a && b <= c)
            {
                min = b;
            }
            if (c <= a && c <= b)
            {
                min = c;
            }
            return min;
        }
    }
}
