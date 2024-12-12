using System;
using System.Collections.Generic;
using System.Linq;

namespace Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<double> newList = new List<double>();
            for (int i = 0; i < numbers.Count / 2; i++)
            {
                double sum = numbers[i] + (numbers[numbers.Count - 1 - i]);
                newList.Add(sum);
            }
            if (numbers.Count % 2 != 0)
            {
                newList.Add(numbers[numbers.Count / 2]);
            }
            Console.WriteLine(string.Join(" ", newList));
        }
    }
}
