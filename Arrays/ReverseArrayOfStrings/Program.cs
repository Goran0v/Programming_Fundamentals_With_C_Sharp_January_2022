using System;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] items = Console.ReadLine().Split();

            Array.Reverse(items);
            Console.Write(string.Join(" ", items));
        }
    }
}
