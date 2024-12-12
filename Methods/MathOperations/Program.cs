using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(GetResult(a, @operator, b));
        }
        static double GetResult(double a, string @operator, double b)
        {
            double result = 0;
            if (@operator == "+")
            {
                result = a + b;
            }
            else if(@operator == "-")
            {
                result = a - b;
            }
            else if (@operator == "*")
            {
                result = a * b;
            }
            else if (@operator == "/")
            {
                result = a / b;
            }
            return result;
        }
    }
}
