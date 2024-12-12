using System;
using System.Linq;
using System.Collections.Generic;

namespace StoreBoxes
{
    class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
    class Box
    {
        public int SerialNumber { get; set; }
        public string Item { get; set; }
        public int ItemQuantity { get; set; }
        public double PriceForABox { get; set; }
        public double AllPrice { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Box> items = new List<Box>();
            while (command != "end")
            {
                string[] data = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int serialNumber = int.Parse(data[0]);
                string name = data[1];
                int itemQuantity = int.Parse(data[2]);
                double price = double.Parse(data[3]);
                Box item = new Box()
                {
                    SerialNumber = serialNumber,
                    Item = name,
                    ItemQuantity = itemQuantity,
                    PriceForABox = price,
                    AllPrice = price * itemQuantity
                };
                items.Add(item);
                command = Console.ReadLine();
            }
            List<Box> sortedBox = items.OrderByDescending(items => items.AllPrice).ToList();

            foreach (Box item in sortedBox)
            {
                Console.WriteLine($"{item.SerialNumber}");
                Console.WriteLine($"-- {item.Item} - ${item.PriceForABox:f2}: {item.ItemQuantity}");
                Console.WriteLine($"-- ${item.AllPrice:f2}");
            }
        }
    }
}
