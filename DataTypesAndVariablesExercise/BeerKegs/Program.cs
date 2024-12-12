using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            string model = string.Empty;
            decimal radius = 0;
            uint height = 0;
            double volume = 0;
            double maximal = double.MinValue;
            string max = string.Empty;
            for (int i = 1; i <= n; i++)
            {
                model = Console.ReadLine();
                radius = decimal.Parse(Console.ReadLine());
                height = uint.Parse(Console.ReadLine());
                volume = Math.PI * Math.Pow(Decimal.ToDouble(radius), 2) * height;
                if (volume > maximal)
                {
                    maximal = volume;
                    max = model;
                }
            }
            Console.WriteLine(max);
        }
    }
}
