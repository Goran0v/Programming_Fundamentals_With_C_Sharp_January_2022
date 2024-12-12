using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] daysOfTheWeek = new string[]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            /*daysOfTheWeek[0] = "Monday";
            daysOfTheWeek[1] = "Tuesday";
            daysOfTheWeek[2] = "Wednesday";
            daysOfTheWeek[3] = "Thursday";
            daysOfTheWeek[4] = "Friday";
            daysOfTheWeek[5] = "Saturday";
            daysOfTheWeek[6] = "Sunday";*/

            if (n >= 1 && n <= 7)
            {
                Console.WriteLine(daysOfTheWeek[n - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }

            //else if (n == 2)
            //{
            //    Console.WriteLine(daysOfTheWeek[1]);
            //}
            //else if (n == 3)
            //{
            //    Console.WriteLine(daysOfTheWeek[2]);
            //}
            //else if (n == 4)
            //{
            //    Console.WriteLine(daysOfTheWeek[3]);
            //}
            //else if (n == 5)
            //{
            //    Console.WriteLine(daysOfTheWeek[4]);
            //}
            //else if (n == 6)
            //{
            //    Console.WriteLine(daysOfTheWeek[5]);
            //}
            //else if (n == 7)
            //{
            //    Console.WriteLine(daysOfTheWeek[6]);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid day!");
            //}
            
        }
    }
}
