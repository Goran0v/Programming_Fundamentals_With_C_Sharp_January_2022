using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawActivation = Console.ReadLine();
            string originalActivation = rawActivation;
            string command = Console.ReadLine();
            while (command != "Generate")
            {
                string[] commandParams = command.Split(">>>", StringSplitOptions.RemoveEmptyEntries);
                string action = commandParams[0];
                if (action == "Contains")
                {
                    string word = commandParams[1];
                    if (rawActivation.Contains(word))
                    {
                        Console.WriteLine($"{rawActivation} contains {word}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (action == "Flip")
                {
                    string flip = commandParams[1];
                    int startIndex = int.Parse(commandParams[2]);
                    int endIndex = int.Parse(commandParams[3]);
                    string textToFlip = rawActivation.Substring(startIndex, endIndex - startIndex);
                    if (flip == "Lower")
                    {
                        textToFlip = textToFlip.ToLower();
                    }
                    else
                    {
                        textToFlip = textToFlip.ToUpper();
                    }
                    rawActivation = rawActivation.Remove(startIndex, endIndex - startIndex);
                    rawActivation = rawActivation.Remove(startIndex, endIndex - startIndex);
                    rawActivation = rawActivation.Insert(startIndex, textToFlip);
                }
                else if (action == "Slice")
                {
                    int startIndex = int.Parse(commandParams[1]);
                    int endIndex = int.Parse(commandParams[2]);
                    rawActivation = rawActivation.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(rawActivation);
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is {rawActivation}");
        }
    }
}
