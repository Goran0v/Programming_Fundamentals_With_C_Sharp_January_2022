using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            const double NUTS = 2;
            const double WATER = 0.7;
            const double CRISPS = 1.5;
            const double SODA = 0.8;
            const double COKE = 1;
            string articles = Console.ReadLine();
            double sum = 0;
            while (articles != "Start")
            {
                double money = double.Parse(articles);
                if (money == 2 || money == 1 || money == 0.5 || money == 0.2 || money == 0.1)
                {
                    sum += money;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {money}");
                }
                articles = Console.ReadLine();
            }
            while (true)
            {
                articles = Console.ReadLine();
                if (articles == "End")
                {
                    break;
                }
                else if (articles == "Nuts")
                {
                    if (sum >= NUTS)
                    {
                        sum -= NUTS;
                        Console.WriteLine($"Purchased nuts");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (articles == "Water")
                {
                    if (sum >= WATER)
                    {
                        sum -= WATER;
                        Console.WriteLine($"Purchased water");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (articles == "Crisps")
                {
                    if (sum >= CRISPS)
                    {
                        sum -= CRISPS;
                        Console.WriteLine($"Purchased crisps");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (articles == "Soda")
                {
                    if (sum >= SODA)
                    {
                        sum -= SODA;
                        Console.WriteLine($"Purchased soda");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (articles == "Coke")
                {
                    if (sum >= COKE)
                    {
                        sum -= COKE;
                        Console.WriteLine($"Purchased coke");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
            }
            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}