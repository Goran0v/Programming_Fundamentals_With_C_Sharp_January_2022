using System;
using System.Linq;
using System.Collections.Generic;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = Console.ReadLine();
            while (true)
            {
                if (command == "end")
                {
                    break;
                }
                string[] functions = command.Split(' ');
                string function = functions[0];
                if (function == "Delete")
                {
                    int num = int.Parse(functions[1]);
                    while (list.Contains(num))
                    {
                        list.Remove(num);
                    }
                }
                else if (function == "Insert")
                {
                    int num = int.Parse(functions[1]);
                    int index = int.Parse(functions[2]);
                    list.Insert(index, num);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}