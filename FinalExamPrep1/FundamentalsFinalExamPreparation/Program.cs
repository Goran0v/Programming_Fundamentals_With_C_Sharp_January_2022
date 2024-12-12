using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace FundamentalsFinalExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string command = Console.ReadLine();
            while (command != "Reveal")
            {
                string[] arr = command.Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                string element = arr[0];
                if (element == "InsertSpace")
                {
                    int insertIndex = int.Parse(arr[1]);
                    message = message.Insert(insertIndex, " ");
                    Console.WriteLine(message);
                }
                else if (element == "Reverse")
                {
                    string substring = arr[1];
                    if (message.Contains(substring))
                    {
                        int first = message.IndexOf(substring);
                        message = message.Remove(first, substring.Length);
                        message += string.Join("", substring.Reverse());
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    
                }
                else if (element == "ChangeAll")
                {
                    string substring = arr[1];
                    string replacement = arr[2];
                    message = message.Replace(substring, replacement);
                    Console.WriteLine(message);
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}