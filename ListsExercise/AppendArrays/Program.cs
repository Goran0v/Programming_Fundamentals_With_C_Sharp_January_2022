using System;
using System.Linq;
using System.Collections.Generic;

namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).Reverse().ToList();
            List<int> currentList = new List<int>();
            List<string> nums = new List<string>();
            for (int i = 0; i < list.Count; i++)
            {
                currentList.AddRange(list[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }
            Console.WriteLine(string.Join(" ", currentList));
        }
    }
}
