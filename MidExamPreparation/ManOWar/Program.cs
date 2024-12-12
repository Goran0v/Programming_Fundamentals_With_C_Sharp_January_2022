using System;
using System.Collections.Generic;
using System.Linq;

namespace ManOWar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShip = Console.ReadLine().Split('>', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> warShip = Console.ReadLine().Split('>', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int maxHealth = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            while (command != "Retire")
            {
                string[] splitCommand = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = splitCommand[0];
                if (action == "Fire")
                {
                    int attackWarshipIndex = int.Parse(splitCommand[1]);
                    int attackDamage = int.Parse(splitCommand[2]);
                    if (attackWarshipIndex >= 0 && attackWarshipIndex < warShip.Count)
                    {
                        warShip[attackWarshipIndex] -= attackDamage;
                        if (warShip[attackWarshipIndex] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }
                    }
                }
                else if (action == "Defend")
                {
                    int startIndex = int.Parse(splitCommand[1]);
                    int endIndex = int.Parse(splitCommand[2]);
                    int damage = int.Parse(splitCommand[3]);
                    if (startIndex >= 0 && startIndex < pirateShip.Count && endIndex >= 0 && endIndex < pirateShip.Count)
                    {
                        for (int i = startIndex; i < endIndex; i++)
                        {
                            pirateShip[i] -= damage;
                            if (pirateShip[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }
                    }
                    
                }
                else if (action == "Repair")
                {
                    int index = int.Parse(splitCommand[1]);
                    int repairing = int.Parse(splitCommand[2]);

                    if (index >= 0 && index < pirateShip.Count)
                    {
                        if (pirateShip[index] + repairing < maxHealth)
                        {
                            pirateShip[index] += repairing;
                        }
                        else
                        {
                            pirateShip[index] = maxHealth;
                        }
                    }
                }
                else if (action == "Status")
                {
                    List<int> sectionsInNeedOfRepair = pirateShip.FindAll(x => (x < 0.2 * maxHealth));
                    Console.WriteLine($"{sectionsInNeedOfRepair.Count} sections need repair.");
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
            Console.WriteLine($"Warship status: {warShip.Sum()}");
        }
    }
}
