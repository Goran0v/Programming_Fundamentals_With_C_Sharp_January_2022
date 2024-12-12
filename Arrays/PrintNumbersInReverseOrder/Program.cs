using System;

namespace PrintNumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                //int num = int.Parse(Console.ReadLine());
                numArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = numArray.Length - 1; i >= 0; i--)
            {
                Console.Write($"{numArray[i]} ");
            }
        }
    }
}
