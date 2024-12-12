using System;

namespace SoftuniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            int counter = 0;
            int other = 0;
            int allHours = firstEmployee + secondEmployee + thirdEmployee;

            while (true)
            {
                other++;
                if (studentsCount <= 0)
                {
                    break;
                }
                if (other % 4 != 0)
                {
                    studentsCount -= allHours;
                    counter++;
                }
                else
                {
                    counter++;
                }
                
            }
            Console.WriteLine($"Time needed: {counter}h.");
        }
    }
}
