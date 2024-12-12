using System;
using System.Linq;
using System.Collections.Generic;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int counter = 0;
            while (true)
            {
                if (command == "end")
                {
                    break;
                }
                string[] functions = command.Split(' ');
                string function = functions[0];
                if (function == "Add")
                {
                    int addNumber = int.Parse(functions[1]);
                    wagons.Add(addNumber);
                }
                else
                {
                    int number = int.Parse(function);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if ((wagons[i] + number) <= maxCapacity)
                        {
                            wagons[i] += number;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
