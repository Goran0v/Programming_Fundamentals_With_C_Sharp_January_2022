using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            PrintOrders(product, quantity);
        }
        static void PrintOrders(string product, int quantity)
        {
            const double WATER = 1;
            const double COFFEE = 1.5;
            const double COKE = 1.4;
            const double SNACKS = 2;
            double sum = 0;

            if (product == "water")
            {
                sum = quantity * WATER;
            }
            else if (product == "coffee")
            {
                sum = quantity * COFFEE;
            }
            else if (product == "coke")
            {
                sum = quantity * COKE;
            }
            else if (product == "snacks")
            {
                sum = quantity * SNACKS;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
