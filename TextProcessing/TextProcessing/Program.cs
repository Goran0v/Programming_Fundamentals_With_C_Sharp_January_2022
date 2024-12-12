using System;
using System.Collections.Generic;
using System.Linq;

namespace TextProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;
            string reversed = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                for (int i = command.Length - 1; i >= 0; i--)
                {
                    reversed += command[i];
                }
                Console.WriteLine($"{command} = {reversed}");
                reversed = string.Empty;
            }
        }
    }
}