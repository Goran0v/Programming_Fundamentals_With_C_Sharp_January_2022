using System;
using System.Linq;

namespace ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] function = command.Split();
                string action = function[0];
                if (action == "swap")
                {
                    int firstToSwap = int.Parse(function[1]);
                    int secondToSwap = int.Parse(function[2]);
                    int second = integers[firstToSwap];
                    integers[firstToSwap] = integers[secondToSwap];
                    integers[secondToSwap] = second;
                }
                else if (action == "multiply")
                {
                    int firstToMultiply = int.Parse(function[1]);
                    int multiplier = int.Parse(function[2]);
                    integers[firstToMultiply] *= integers[multiplier];
                }
                else if (action == "decrease")
                {
                    for (int i = 0; i < integers.Length; i++)
                    {
                        integers[i]--;
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", integers));
        }
    }
}
