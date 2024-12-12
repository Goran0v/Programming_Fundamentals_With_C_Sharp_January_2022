using System;
using System.Linq;

namespace MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());
            int counter = 0;
            int index = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == number && i < arr.Length - 1)
                    {
                        counter++;
                        index = i + 1 - counter;
                        Console.WriteLine($"{arr[i]} {arr[j]}");
                    }
                    else if (arr[i] + arr[i + 1] != number && i < arr.Length - 1)
                    {
                        counter = 0;
                    }
                }
            }
        }
    }
}
