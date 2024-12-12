using System;

namespace MidExam
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double priceForFlour = double.Parse(Console.ReadLine());
            double priceForAnEgg = double.Parse(Console.ReadLine());
            double priceForAnApron = double.Parse(Console.ReadLine());
            int freeFlourPackages = studentsCount / 5;
            double sum = priceForAnApron * (studentsCount + Math.Ceiling(0.2 * studentsCount)) + priceForAnEgg * 10 * studentsCount + priceForFlour * (studentsCount - freeFlourPackages);

            if (budget >= sum)
            {
                Console.WriteLine($"Items purchased for {sum:f2}$.");
            }
            else
            {
                double neededMoney = sum - budget;
                Console.WriteLine($"{neededMoney:f2}$ more needed.");
            }
        }
    }
}
