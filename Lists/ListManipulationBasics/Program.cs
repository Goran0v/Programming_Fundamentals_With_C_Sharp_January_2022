using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] token = command.Split();
                string action = token[0];

                if (action == "Add")
                {
                    int numToAdd = int.Parse(token[1]);
                    numbers.Add(numToAdd);
                }
                else if (action == "Remove")
                {
                    int numToRemove = int.Parse(token[1]);
                    numbers.Remove(numToRemove);
                }
                else if (action == "RemoveAt")
                {
                    int index = int.Parse(token[1]);
                    numbers.RemoveAt(index);
                }
                else if (action == "Insert")
                {
                    int indexx = int.Parse(token[2]);
                    int numToInsert = int.Parse(token[1]);
                    numbers.Insert(indexx, numToInsert);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
