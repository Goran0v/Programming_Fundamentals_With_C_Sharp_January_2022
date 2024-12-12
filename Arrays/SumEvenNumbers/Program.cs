using System;
using System.Linq;

namespace SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] nums = Console.ReadLine().Split();
            //int[] evens = new int[nums.Length];
            int[] evens = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            //for (int i = 0; i < evens.Length; i++)
            {
                //evens[i] = int.Parse(nums[i]);
                //if (evens[i] % 2 == 0)
                {
                //    sum += evens[i];
                }
            }
            //Console.WriteLine(sum);

            foreach (int item in evens)
            {
                if (item % 2 == 0)
                {
                    sum += item;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
