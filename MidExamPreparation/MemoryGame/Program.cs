using System;
using System.Linq;
using System.Collections.Generic;

namespace MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = Console.ReadLine();
            int moveCount = 0;
            while (command != "end")
            {
                moveCount++;
                string[] rawGuess = command.Split();
                int firstGuess = int.Parse(rawGuess[0]);
                int secondGuess = int.Parse(rawGuess[1]);
                if (IsInvalidGuess(firstGuess, secondGuess, elements))
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    int middleOfElements = elements.Count / 2;
                    string elementToAdd = $"-{moveCount}a";
                    elements.Insert(middleOfElements, elementToAdd);
                    elements.Insert(middleOfElements, elementToAdd);
                }
                else if (elements[firstGuess] == elements[secondGuess])
                {
                    string guessedElement = elements[firstGuess];
                    elements.Remove(guessedElement);
                    elements.Remove(guessedElement);
                    Console.WriteLine($"Congrats! You have found matching elements - {guessedElement}!");
                }
                else if (elements[firstGuess] != elements[secondGuess])
                {
                    Console.WriteLine("Try again!");
                }

                if (elements.Count == 0)
                {
                    Console.WriteLine($"You have won in {moveCount} turns!");
                    break;
                }
                command = Console.ReadLine();
            }

            if (elements.Count > 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", elements));
            }
        }
        static bool IsGuessInTheList(int guess, List<string> elements)
        {
            return guess >= 0 && guess < elements.Count;
        }
        static bool IsInvalidGuess(int firstGuess, int secondGuess, List<string> elements)
        {
            return firstGuess == secondGuess || !IsGuessInTheList(firstGuess, elements) || !IsGuessInTheList(secondGuess, elements);
        }
    }
}
