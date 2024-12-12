using System;
using System.Linq;
using System.Collections.Generic;

namespace VehicleCatalogue
{
    class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            this.Brand = brand;
            this.Model = model;
            this.Weight = weight;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
    class Car
    {
        public Car(string brand, string model, int horsepower)
        {
            this.Brand = brand;
            this.Model = model;
            this.Horsepower = horsepower;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Horsepower { get; set; }
    }
    class Catalogue
    {
        public Catalogue()
        {
            this.Trucks = new List<Truck>();
            this.Cars = new List<Car>();
        }
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Catalogue catalogueObject = new Catalogue();
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] data = command.Split('/', StringSplitOptions.RemoveEmptyEntries);
                string type = data[0];
                string brand = data[1];
                string model = data[2];
                int final = int.Parse(data[3]);
                if (type == "Car")
                {
                    Car newCar = new Car(brand, model, final);
                    catalogueObject.Cars.Add(newCar);
                }
                if (type == "Truck")
                {
                    Truck newTruck = new Truck(brand, model, final);
                    catalogueObject.Trucks.Add(newTruck);
                }
                command = Console.ReadLine();
            }

            if (catalogueObject.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                List<Car> orderedCars = catalogueObject.Cars.OrderBy(car => car.Brand).ToList();
                foreach (Car car in orderedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.Horsepower}hp");
                }
            }
            if (catalogueObject.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                List<Truck> orderedTrucks = catalogueObject.Trucks.OrderBy(truck => truck.Brand).ToList();
                foreach (Truck truck in orderedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
            
        }
    }
}
