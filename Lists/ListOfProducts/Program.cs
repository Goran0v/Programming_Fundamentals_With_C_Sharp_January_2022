using System;
using System.Collections.Generic;

namespace ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> numeredProducts = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string product = Console.ReadLine();
                numeredProducts.Add(product);
            }

            numeredProducts.Sort();

            for (int i = 0; i < numeredProducts.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{numeredProducts[i]}");
            }
        }
    }
}
