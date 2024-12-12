using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace HeroRecruitment
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Dictionary<string, List<string>> heroes = new Dictionary<string, List<string>>();
            while ((input = Console.ReadLine()) != "End")
            {
                string[] arr = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = arr[0];
                if (command == "Enroll")
                {
                    string heroName = arr[1];
                    if (!heroes.ContainsKey(heroName))
                    {
                        List<string> newList = new List<string>();
                        heroes.Add(heroName, newList);
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} is already enrolled.");
                    }
                }
                else if (command == "Learn")
                {
                    string heroName = arr[1];
                    string spell = arr[2];
                    if (heroes.ContainsKey(heroName))
                    {
                        if (!heroes[heroName].Contains(spell))
                        {
                            heroes[heroName].Add(spell);
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} has already learnt {spell}.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                    }
                }
                else if (command == "Unlearn")
                {
                    string heroName = arr[1];
                    string spell = arr[2];
                    if (heroes.ContainsKey(heroName))
                    {
                        if (heroes[heroName].Contains(spell))
                        {
                            heroes[heroName].Remove(spell);
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} doesn't know {spell}.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                    }
                }
            }

            Console.WriteLine("Heroes:");
            foreach (KeyValuePair<string, List<string>> heroe in heroes)
            {
                Console.WriteLine($"== {heroe.Key}: {string.Join(", ", heroe.Value)}");
            }
        }
    }
}
