using System;
using System.Linq;
using System.Collections.Generic;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int[] bombs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int bombNumber = bombs[0];
            int power = bombs[1];
            
            while (true)
            {
                int indexOfBomb = numbers.IndexOf(bombNumber);

                if (indexOfBomb == -1)
                {
                    break;
                }

                DetonateBomb(numbers, indexOfBomb, power);
            }

            Console.WriteLine(numbers.Sum());
        }

        static void DetonateBomb(List<int> numbers, int indexOfBomb, int power)
        {
            int rightIndex = indexOfBomb + power;
            for (int i = indexOfBomb; i <= rightIndex; i++)
            {
                if (indexOfBomb >= numbers.Count)
                {
                    break;
                }
                numbers.RemoveAt(indexOfBomb);
            }

            int leftCount = indexOfBomb - power;
            if (leftCount < 0)
            {
                leftCount = 0;
            }
            for (int i = leftCount; i < indexOfBomb; i++)
            {
                if (leftCount >= numbers.Count)
                {
                    break;
                }
                numbers.RemoveAt(leftCount);
            }
        }
    }
}
