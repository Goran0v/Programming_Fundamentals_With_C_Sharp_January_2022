using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double area = PrintArea(a, b);
            Console.WriteLine(area);
        }
        static double PrintArea(double a, double b)
        {
            return a * b;
        }
    }
}
