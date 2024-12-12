using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string input = Console.ReadLine();
            while (input != "Done")
            {
                string[] arr = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = arr[0];
                if (command == "TakeOdd")
                {
                    char[] odd = password.Where((symbol, index) => index % 2 != 0).ToArray();
                    password = string.Join("", odd);
                    Console.WriteLine(password);
                }
                else if (command == "Cut")
                {
                    int index = int.Parse(arr[1]);
                    int length = int.Parse(arr[2]);
                    password = password.Remove(index, length);
                    Console.WriteLine(password);
                }
                else if (command == "Substitute")
                {
                    string substring = arr[1];
                    string substitute = arr[2];
                    if (password.Contains(substring))
                    {
                        password = password.Replace(substring, substitute);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
