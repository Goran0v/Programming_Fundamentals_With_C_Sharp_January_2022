using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();
            bool hasChanges = false;

            while (command != "end")
            {
                string[] token = command.Split();
                string action = token[0];

                if (action == "Add")
                {
                    int numToAdd = int.Parse(token[1]);
                    numbers.Add(numToAdd);
                    hasChanges = true;
                }
                else if (action == "Remove")
                {
                    int numToRemove = int.Parse(token[1]);
                    numbers.Remove(numToRemove);
                    hasChanges = true;
                }
                else if (action == "RemoveAt")
                {
                    int index = int.Parse(token[1]);
                    numbers.RemoveAt(index);
                    hasChanges = true;
                }
                else if (action == "Insert")
                {
                    int indexx = int.Parse(token[2]);
                    int numToInsert = int.Parse(token[1]);
                    numbers.Insert(indexx, numToInsert);
                    hasChanges = true;
                }
                else if (action == "Contains")
                {
                    int numToCheck = int.Parse(token[1]);
                    if (numbers.Contains(numToCheck))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (action == "PrintEven")
                {
                    List<int> evenNumbers = numbers.FindAll(x => x % 2 == 0);
                    Console.WriteLine(string.Join(" ", evenNumbers));
                }
                else if (action == "PrintOdd")
                {
                    List<int> oddNumbers = numbers.FindAll(x => x % 2 != 0);
                    Console.WriteLine(string.Join(" ", oddNumbers));
                }
                else if (action == "GetSum")
                {
                    int sum = numbers.Sum();
                    Console.WriteLine(sum);
                }
                else if (action == "Filter")
                {
                    string condition = token[1];
                    int numberForComparison = int.Parse(token[2]);
                    List<int> result = GetFilteredNumbers(numbers, condition, numberForComparison);
                    Console.WriteLine(string.Join(" ", result));
                }

                command = Console.ReadLine();
            }

            if (hasChanges)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }

        static List<int> GetFilteredNumbers(List<int> allNumbers, string condition, int numToCompare)
        {
            if (condition == "<")
            {
                List<int> result = allNumbers.FindAll(x => x < numToCompare);
                return result;
            }
            else if (condition == ">")
            {
                List<int> result = allNumbers.FindAll(x => x > numToCompare);
                return result;
            }
            else if (condition == "<=")
            {
                List<int> result = allNumbers.FindAll(x => x <= numToCompare);
                return result;
            }
            else if (condition == ">=")
            {
                List<int> result = allNumbers.FindAll(x => x >= numToCompare);
                return result;
            }
            else
            {
                return allNumbers;
            }
        }
    }
}
