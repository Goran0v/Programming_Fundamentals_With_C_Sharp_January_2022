using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            uint startingYield = uint.Parse(Console.ReadLine());
            int days = 0;
            int spice = 0;

            while (startingYield >= 100)
            {
                spice += (int)startingYield;
                startingYield -= 10;
                if (spice >= 26)
                {
                    spice -= 26;
                }
                else
                {
                    continue;
                }
                days++;
            }
            if (spice >= 26)
            {
                spice -= 26;
            }
            Console.WriteLine($"{days}");
            Console.WriteLine($"{spice}");
        }
    }
}
