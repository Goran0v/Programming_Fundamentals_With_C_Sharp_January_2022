using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotationsCount = int.Parse(Console.ReadLine());

            for (int rot = 1; rot <= rotationsCount; rot++)
            {
                int firstEl = arr[0];
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[arr.Length - 1] = firstEl;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
