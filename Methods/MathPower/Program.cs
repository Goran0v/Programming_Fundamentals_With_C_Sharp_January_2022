using System;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            Console.WriteLine(ReturnPower(a, power));
        }
        static double ReturnPower(double a, double power)
        {
            return Math.Pow(a, power);
        }
    }
}
