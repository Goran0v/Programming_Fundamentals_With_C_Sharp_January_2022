using System;
using System.Linq;
using System.Collections.Generic;

namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstDeck = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> secondDeck = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int firstSum = 0;
            int secondSum = 0;
            while (true)
            {
                if (firstDeck[0] > secondDeck[0])
                {
                    firstDeck.Add(firstDeck[0]);
                    firstDeck.Add(secondDeck[0]);
                }
                else if (firstDeck[0] < secondDeck[0])
                {
                    secondDeck.Add(secondDeck[0]);
                    secondDeck.Add(firstDeck[0]);
                }
                firstDeck.Remove(firstDeck[0]);
                secondDeck.Remove(secondDeck[0]);
                if (firstDeck.Count == 0)
                {
                    secondSum = secondDeck.Sum();
                    Console.WriteLine($"Second player wins! Sum: {secondSum}");
                    break;
                }
                else if (secondDeck.Count == 0)
                {
                    firstSum = firstDeck.Sum();
                    Console.WriteLine($"First player wins! Sum: {firstSum}");
                    break;
                }
            }
        }
    }
}
