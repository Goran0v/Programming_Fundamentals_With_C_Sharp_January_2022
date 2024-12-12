using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace FinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            string spell = Console.ReadLine();
            string input;
            while ((input = Console.ReadLine()) != "Abracadabra")
            {
                string[] arr = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = arr[0];
                if (command == "Abjuration")
                {
                    spell = spell.ToUpper();
                    Console.WriteLine(spell);
                }
                else if (command == "Necromancy")
                {
                    spell = spell.ToLower();
                    Console.WriteLine(spell);
                }
                else if (command == "Illusion")
                {
                    int index = int.Parse(arr[1]);
                    string letter = arr[2];
                    if (index >= 0 && index < spell.Length)
                    {
                        spell = spell.Insert(index, letter);
                        spell = spell.Remove(index + 1, 1);
                        Console.WriteLine("Done!");
                    }
                    else
                    {
                        Console.WriteLine("The spell was too weak.");
                    }
                }
                else if (command == "Divination")
                {
                    string substring = arr[1];
                    string replacement = arr[2];
                    if (spell.Contains(substring))
                    {
                        spell = spell.Replace(substring, replacement);
                        Console.WriteLine(spell);
                    }
                }
                else if (command == "Alteration")
                {
                    string substring = arr[1];
                    if (spell.Contains(substring))
                    {
                        int index = spell.IndexOf(substring);
                        spell = spell.Remove(index, substring.Length);
                        Console.WriteLine(spell);
                    }
                }
                else
                {
                    Console.WriteLine("The spell did not work!");
                }
            }
        }
    }
}
