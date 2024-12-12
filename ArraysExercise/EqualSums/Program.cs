using System;
using System.Linq;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;
            if (arr.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                
                leftSum = arr.Take(i).Sum();
                rightSum = arr.Skip(i + 1).Sum();

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
