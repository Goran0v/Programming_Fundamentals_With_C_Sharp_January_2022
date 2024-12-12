using System;
using System.Linq;
using System.Collections.Generic;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            double average = integers.Sum() * 1.0 / integers.Count();
            List<int> topNumbers = new List<int>();
            int counter = 0;
            integers.Sort();
            for (int i = integers.Count - 1; i >= 0; i--)
            {
                if (integers[i] > average)
                {
                    topNumbers.Add(integers[i]);
                    counter++;
                }
                if (counter == 5)
                {
                    break;
                }
            }

            if (counter != 0)
            {
                Console.WriteLine(string.Join(" ", topNumbers));
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
