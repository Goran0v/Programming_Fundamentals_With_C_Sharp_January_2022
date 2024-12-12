using System;
using System.Linq;
using System.Collections.Generic;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] commands = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string function = commands[0];

                if (function == "Add")
                {
                    int toAdd = int.Parse(commands[1]);
                    numbers.Add(toAdd);
                }
                else if (function == "Insert")
                {
                    int number = int.Parse(commands[1]);
                    int index = int.Parse(commands[2]);
                    if (!IsIndexValid(numbers, index))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.Insert(index, number);
                }
                else if (function == "Remove")
                {
                    int index = int.Parse(commands[1]);
                    if (!IsIndexValid(numbers, index))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.RemoveAt(index);
                }
                else if (function == "Shift")
                {
                    string direction = commands[1];
                    int count = int.Parse(commands[2]);
                    if (direction == "left")
                    {
                        ShiftLeft(numbers, count);
                    }
                    else if (direction == "right")
                    {
                        ShiftRight(numbers, count);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        static bool IsIndexValid(List<int> numbers, int index)
        {
            return index >= 0 && index < numbers.Count;
        }
        static void ShiftLeft(List<int> numbers, int count)
        {
            int realPerformedCount = count % numbers.Count;
            for (int i = 1; i <= realPerformedCount; i++)
            {
                int firstElement = numbers.First();
                numbers.Remove(firstElement);
                numbers.Add(firstElement);
            }
        }
        static void ShiftRight(List<int> numbers, int count)
        {
            int realPerformedCount = count % numbers.Count;
            for (int i = 1; i <= realPerformedCount; i++)
            {
                int lastElement = numbers.Last();
                numbers.RemoveAt(numbers.Count - 1);
                numbers.Insert(0, lastElement);
            }
        }
    }
}
