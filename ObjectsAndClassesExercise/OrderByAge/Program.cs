using System;
using System.Linq;
using System.Collections.Generic;

namespace OrderByAge
{
    class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
        public Person(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }

        public Person()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<Person> people = new List<Person>();
            Person person = new Person();
            while (arr[0] != "End")
            {
                string name = arr[0];
                string id = arr[1];
                int age = int.Parse(arr[2]);
                if (people.Any(p => p.ID == id))
                {
                    ChangeData(name, age, person);
                }
                else
                {
                    person = new Person(name, id, age);
                    people.Add(person);
                }
                arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            List<Person> ordered = people.OrderBy(a => a.Age).ToList();
            foreach (Person person1 in ordered)
            {
                Console.WriteLine($"{person1.Name} with ID: {person1.ID} is {person1.Age} years old.");
            }
        }
        static void ChangeData(string currentName, int currentAge, Person person)
        {
            person.Name = currentName;
            person.Age = currentAge;
        }
    }
}
