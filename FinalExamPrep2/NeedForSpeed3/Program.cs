using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeedForSpeed3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<int>> cars = new Dictionary<string, List<int>>();
            for (int i = 1; i <= n; i++)
            {
                string[] arr = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
                string car = arr[0];
                int mileage = int.Parse(arr[1]);
                int fuel = int.Parse(arr[2]);
                List<int> data = new List<int>();
                data.Add(mileage);
                data.Add(fuel);
                cars.Add(car, data);
            }

            string input;
            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] arr = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string command = arr[0];
                string car = arr[1];
                if (command == "Drive")
                {
                    int distance = int.Parse(arr[2]);
                    int fuelNeeded = int.Parse(arr[3]);
                    if (cars[car][1] < fuelNeeded)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        cars[car][0] += distance;
                        cars[car][1] -= fuelNeeded;
                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuelNeeded} liters of fuel consumed.");
                    }

                    if (cars[car][0] >= 100000)
                    {
                        Console.WriteLine($"Time to sell the {car}!");
                        cars.Remove(car);
                    }
                }
                else if (command == "Refuel")
                {
                    int fuel = int.Parse(arr[2]);
                    if (cars[car][1] + fuel > 75)
                    {
                        int fuelRefilled = cars[car][1] + fuel - 75;
                        cars[car][1] = 75;
                        Console.WriteLine($"{car} refueled with {fuelRefilled} liters");
                    }
                    else
                    {
                        cars[car][1] += fuel;
                        Console.WriteLine($"{car} refueled with {fuel} liters");
                    }
                }
                else if (command == "Revert")
                {
                    int kilometers = int.Parse(arr[2]);
                    if (cars[car][0] - kilometers >= 10000)
                    {
                        cars[car][0] -= kilometers;
                        Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                    }
                    else
                    {
                        cars[car][0] = 10000;
                    }
                }
            }

            foreach (KeyValuePair<string, List<int>> car in cars)
            {
                string carName = car.Key;
                Console.WriteLine($"{carName} -> Mileage: {car.Value[0]} kms, Fuel in the tank: {car.Value[1]} lt.");
            }
        }
    }
}
