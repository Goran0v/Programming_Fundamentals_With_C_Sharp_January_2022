using System;
using System.Linq;
using System.Collections.Generic;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string command = Console.ReadLine();
            while (command != "Finish")
            {
                string[] function = command.Split();
                string action = function[0];
                if (action == "Add")
                {
                    int value = int.Parse(function[1]);
                    numbers.Add(value);
                }
                else if (action == "Remove")
                {
                    int value = int.Parse(function[1]);
                    numbers.Remove(value);
                }
                else if (action == "Replace")
                {
                    int value = int.Parse(function[1]);
                    int replacement = int.Parse(function[2]);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == value)
                        {
                            numbers.Remove(value);
                            numbers.Insert(i, replacement);
                            break;
                        }
                    }
                }
                else if (action == "Collapse")
                {
                    int value = int.Parse(function[1]);
                    numbers.RemoveAll(x => x < value);
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
