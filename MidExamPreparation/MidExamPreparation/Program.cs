using System;

namespace MidExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            decimal sumWithNoTax = 0;
            
            while (input != "special" && input != "regular")
            {
                decimal price = decimal.Parse(input);
                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                    input = Console.ReadLine();
                    continue;
                }
                sumWithNoTax += price;
                input = Console.ReadLine();
            }
            decimal taxes = sumWithNoTax * 0.2m;
            decimal totalPriceWithTaxes = sumWithNoTax + taxes;

            if (sumWithNoTax == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }
            else if (input == "special")
            {
                totalPriceWithTaxes *= 0.9m;
                Console.WriteLine($"Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {sumWithNoTax:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPriceWithTaxes:f2}$");
            }
            else if (input == "regular")
            {
                Console.WriteLine($"Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {sumWithNoTax:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPriceWithTaxes:f2}$");
            }
        }
    }
}
