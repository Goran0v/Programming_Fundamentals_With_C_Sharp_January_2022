using System;
using System.Linq;

namespace ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string input = Console.ReadLine();
            int counter = 0;

            while (input != "End")
            {
                int indexOfShot = int.Parse(input);
                if (indexOfShot >= 0 && indexOfShot < targets.Length && targets[indexOfShot] != -1)
                {
                    counter++;
                    for (int i = indexOfShot + 1; i < targets.Length; i++)
                    {
                        if (targets[i] > targets[indexOfShot] && targets[i] != -1)
                        {
                            targets[i] -= targets[indexOfShot];
                        }
                        else if (targets[i] <= targets[indexOfShot] && targets[i] != -1)
                        {
                            targets[i] += targets[indexOfShot];
                        }
                    }
                    for (int i = indexOfShot - 1; i >= 0; i--)
                    {
                        if (targets[i] > targets[indexOfShot] && targets[i] != -1)
                        {
                            targets[i] -= targets[indexOfShot];
                        }
                        else if (targets[i] <= targets[indexOfShot] && targets[i] != -1)
                        {
                            targets[i] += targets[indexOfShot];
                        }
                    }
                    targets[indexOfShot] = -1;
                }
                input = Console.ReadLine();
            }

            Console.Write($"Shot targets: {counter} -> ");
            Console.WriteLine(string.Join(" ", targets));
        }
    }
}