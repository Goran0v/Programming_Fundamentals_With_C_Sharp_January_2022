using System;
using System.Linq;

namespace EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] first = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] second = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            bool different = false;
            if (first.Length == second.Length)
            {
                for (int i = 0; i < first.Length; i++)
                {
                    sum += second[i];
                    if (first[i] != second[i])
                    {
                        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                        different = true;
                        break;
                    }
                }
            }
            if (!different)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
