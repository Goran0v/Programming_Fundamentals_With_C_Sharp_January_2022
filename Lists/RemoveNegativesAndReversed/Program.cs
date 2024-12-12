using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativesAndReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine().Split().Select(int.Parse).ToList();

            first.RemoveAll(x => x < 0);

            first.Reverse();

            if (first.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", first));
            }
        }
    }
}
