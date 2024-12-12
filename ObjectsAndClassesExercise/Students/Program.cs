using System;
using System.Linq;
using System.Collections.Generic;

namespace Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public double Grade { get; set; }
        public Student(string firstName, string secondName, double grade)
        {
            FirstName = firstName;
            SecondName = secondName;
            Grade = grade;
        }
        //public override string ToString()
        //{
        //    return $"{FirstName} {SecondName}: {Grade:f2}";
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> article = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                string[] studentInformation = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                var newArticle = new Student(studentInformation[0], studentInformation[1], double.Parse(studentInformation[2]));
                article.Add(newArticle);
            }

            article = article.OrderBy(x => x.Grade).ToList();
            article.Reverse();

            //Console.WriteLine(string.Join(Environment.NewLine, article));
            foreach (Student student in article)
            {
                Console.WriteLine($"{student.FirstName} {student.SecondName}: {student.Grade:f2}");
            }
        }
    }
}
