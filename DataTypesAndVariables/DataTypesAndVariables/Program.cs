using System;

namespace DataTypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            float newDistance = 0;
            newDistance = distance / 1000.0f;

            Console.WriteLine($"{newDistance:f2}");
        }
    }
}