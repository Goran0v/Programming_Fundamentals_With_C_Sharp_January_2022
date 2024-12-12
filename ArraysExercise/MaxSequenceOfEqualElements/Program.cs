using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 1;
            int number = 0;
            int index = 0;
            int maxNum = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1] && i < arr.Length - 1)
                {
                    counter++;
                    if (maxNum < counter)
                    {
                        maxNum = counter;
                        index = i + 2 - counter;
                    }
                }
                else if (arr[i] != arr[i + 1] && i < arr.Length - 2)
                {
                    counter = 1;
                }

            }
            
            for (int i = index; i < maxNum + index; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
