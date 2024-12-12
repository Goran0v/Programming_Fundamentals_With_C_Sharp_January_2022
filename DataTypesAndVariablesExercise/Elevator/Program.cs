using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int fullCourses = numberOfPeople / capacity;
            int additionalCourse = 0;
            if (numberOfPeople % capacity != 0)
            {
                additionalCourse++;
            }
            int courses = fullCourses + additionalCourse;
            Console.WriteLine(courses);
        }
    }
}
