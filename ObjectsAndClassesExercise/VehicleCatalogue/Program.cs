using System;
using System.Linq;
using System.Collections.Generic;

namespace VehicleCatalogue
{
    class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }
        public Vehicle(string type, string model, string color, int horsepower)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<Vehicle> vehicles = new List<Vehicle>();
            int carCount = 0;
            int truckCount = 0;
            double carHp = 0;
            double truckHp = 0;
            while (arr[0] != "End")
            {
                string type = arr[0];
                string model = arr[1];
                string color = arr[2];
                int horsepower = int.Parse(arr[3]);
                if (type == "car")
                {
                    carCount++;
                    carHp += horsepower;
                }
                else if (type == "truck")
                {
                    truckCount++;
                    truckHp += horsepower;
                }
                Vehicle vehicle = new Vehicle(type, model, color, horsepower);
                vehicles.Add(vehicle);
                arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            string newModel = Console.ReadLine();
            while (newModel != "Close the Catalogue")
            {
                foreach (Vehicle vehicle in vehicles)
                {
                    if (vehicle.Model == newModel)
                    {
                        foreach (Vehicle types in vehicles.Where(v => v.Model == newModel))
                        {
                            if (vehicle.Type == "car")
                            {
                                Console.WriteLine($"Type: Car");
                            }
                            else if (vehicle.Type == "truck")
                            {
                                Console.WriteLine($"Type: Truck");
                            }
                            Console.WriteLine($"Model: {vehicle.Model}");
                            Console.WriteLine($"Color: {vehicle.Color}");
                            Console.WriteLine($"Horsepower: {vehicle.Horsepower}");
                        }
                    }
                }
                newModel = Console.ReadLine();
            }

            double averageCarHP = carHp / carCount;
            double averageTruckHP = truckHp / truckCount;

            if (carCount > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {averageCarHP:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }
            if (truckCount > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {averageTruckHP:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
        }
    }
}
