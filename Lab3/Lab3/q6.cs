using System;
using System.Collections.Generic;
using System.Linq;
namespace q6
{
    class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
    }

    class Marks
    {
        public int StudentId { get; set; }
        public int Score { get; set; }
    }

    class Program
    {
        static void Main()
        {
            // List of students
            List<Student> students = new List<Student>
        {
            new Student { StudentId = 1, Name = "Shrijan" },
            new Student { StudentId = 2, Name = "Laska" },
            new Student { StudentId = 3, Name = "Swornim" }
        };

            // List of marks
            List<Marks> marksList = new List<Marks>
        {
            new Marks { StudentId = 1, Score = 85 },
            new Marks { StudentId = 2, Score = 90 },
            new Marks { StudentId = 3, Score = 78 }
        };

            // LINQ Join: Join students and marks on StudentId
            var joinedData = from student in students
                             join mark in marksList
                             on student.StudentId equals mark.StudentId
                             select new
                             {
                                 student.Name,
                                 mark.Score
                             };

            // Display the result
            Console.WriteLine("Student Name\tScore");
            Console.WriteLine("-------------------------");
            foreach (var item in joinedData)
            {
                Console.WriteLine($"{item.Name}\t\t{item.Score}");
            }
        }
    }
}
