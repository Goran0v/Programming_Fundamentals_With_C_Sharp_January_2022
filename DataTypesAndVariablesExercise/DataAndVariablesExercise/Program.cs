using System;

namespace DataAndVariablesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int fourth = int.Parse(Console.ReadLine());
            int sum = 0;
            int newSum = 0;
            int newestSum = 0;

            sum += second + first;
            newSum = sum / third;
            newestSum = fourth * newSum;

            Console.WriteLine(newestSum);
        }
    }
}
