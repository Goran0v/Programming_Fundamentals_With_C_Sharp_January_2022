using System;
using System.Linq;
using System.Collections.Generic;

namespace Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Hometown { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Student> students = new List<Student>();
            while (command != "end")
            {
                string[] data = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string firstName = data[0];
                string lastName = data[1];
                int age = int.Parse(data[2]);
                string hometown = data[3];
                Student student = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    Hometown = hometown
                };
                students.Add(student);
                command = Console.ReadLine();
            }

            string city = Console.ReadLine();
            foreach (Student student in students)
            {
                if (student.Hometown == city)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
}
