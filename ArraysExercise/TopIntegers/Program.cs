using System;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] topInteger = new int[arr.Length];
            int counter = 0;
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                int curr = arr[i];
                bool isTop = true;
                for (int j = i + 1; j <= arr.Length - 1; j++)
                {
                    int nextNum = arr[j];
                    if (nextNum >= curr)
                    {
                        isTop = false;
                        break;
                    }
                }
                if (isTop)
                {
                    topInteger[counter] = curr;
                    counter++;
                }
            }
            
            for (int i = 0; i < counter; i++)
            {
                int currentTopInteger = topInteger[i];
                Console.Write($"{currentTopInteger} ");
            }
        }
    }
}
