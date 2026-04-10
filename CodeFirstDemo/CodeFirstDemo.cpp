using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add one student
            AddStudent();

            // Show all students (to confirm it worked)
            DisplayAllStudents();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static void AddStudent()
        {
            var student = new Student
            {
                Name = "John Doe",
                Age = 20
            };

            using (var context = new SchoolContext())
            {
                context.Students.Add(student);
                context.SaveChanges();
            }

            Console.WriteLine("Student added successfully.");
        }

        static void DisplayAllStudents()
        {
            using (var context = new SchoolContext())
            {
                var students = context.Students.ToList();

                if (students.Count == 0)
                {
                    Console.WriteLine("No students found.");
                    return;
                }

                Console.WriteLine("\nList of students:");
                foreach(var s in students)
                {
                    Console.WriteLine($"ID: {s.Id}, Name: {s.Name}, Age: {s.Age}");
                }
            }
        }
    }
}