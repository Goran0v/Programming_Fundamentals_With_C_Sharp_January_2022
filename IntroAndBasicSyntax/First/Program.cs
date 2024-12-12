using System;

namespace IntroAndBasicSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 30;
            if (minutes >= 60)
            {
                hours++;
                minutes -= 60;
            }

            if (hours >= 24)
            {
                hours -= 24;
            }

            if (minutes < 10)
            {
                Console.WriteLine($"{hours}:{minutes:d2}");
            }
            else
            {
                Console.WriteLine($"{hours}:{minutes}");
            }
        }
    }
}
