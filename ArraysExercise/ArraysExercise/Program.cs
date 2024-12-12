using System;
using System.Linq;

namespace ArraysExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                int newNum = int.Parse(Console.ReadLine());
                sum += newNum;
                array[i] = newNum;
            }
            Console.WriteLine(string.Join(" ", array));
            Console.WriteLine(sum);
        }
    }
}
