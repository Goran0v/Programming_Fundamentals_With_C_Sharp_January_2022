using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string typeOfPeople = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            double discount = 0;
            
            if (typeOfPeople == "Students")
            {
                if (day == "Friday")
                {
                    price = 8.45;
                }
                else if (day == "Saturday")
                {
                    price = 9.8;
                }
                else if (day == "Sunday")
                {
                    price = 10.46;
                }

                if (people >= 30)
                {
                    discount = 15;
                }
            }
            else if (typeOfPeople == "Business")
            {
                if (day == "Friday")
                {
                    price = 10.9;
                }
                else if (day == "Saturday")
                {
                    price = 15.6;
                }
                else if (day == "Sunday")
                {
                    price = 16;
                }

                if (people >= 100)
                {
                    people -= 10;
                }
            }
            else if (typeOfPeople == "Regular")
            {
                if (day == "Friday")
                {
                    price = 15;
                }
                else if (day == "Saturday")
                {
                    price = 20;
                }
                else if (day == "Sunday")
                {
                    price = 22.5;
                }

                if (people >= 10 && people <= 20)
                {
                    discount = 5;
                }
            }

            double totalPrice = (price * people) * ((100 - discount) / 100);
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
