using System;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            uint N = uint.Parse(Console.ReadLine());
            uint M = uint.Parse(Console.ReadLine());
            byte Y = byte.Parse(Console.ReadLine());
            int counter = 0;
            uint newN = N / 2;

            while (N >= M)
            {
                N -= M;
                counter++;
                if (N == newN && Y != 0)
                {
                    N /= (uint)Y;
                }
            }
            Console.WriteLine(N);
            Console.WriteLine(counter);
        }
    }
}
