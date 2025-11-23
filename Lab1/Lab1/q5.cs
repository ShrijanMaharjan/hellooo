using System;

// Base class
namespace q5
{
    class Person
    {
        public string name;

        public void Display()
        {
            Console.WriteLine("Name: " + name);
        }
    }

    // 1. Single Inheritance
    class Student : Person
    {
        public int rollNo;

        public void ShowStudent()
        {
            Display(); // from base class
            Console.WriteLine("Roll No: " + rollNo);
        }
    }

    // 2. Multiple Inheritance using Interfaces
    interface ISport
    {
        void PlaySport();
    }

    interface IMusic
    {
        void PlayMusic();
    }

    class HobbyStudent : ISport, IMusic
    {
        public void PlaySport()
        {
            Console.WriteLine("Playing Football...");
        }

        public void PlayMusic()
        {
            Console.WriteLine("Playing Guitar...");
        }
    }

    // 3. Multilevel Inheritance
    class GraduateStudent : Student
    {
        public string degree;

        public void ShowGraduate()
        {
            ShowStudent(); // from Student
            Console.WriteLine("Degree: " + degree);
        }
    }

    // 4. Hierarchical Inheritance
    class Teacher : Person
    {
        public string subject;

        public void ShowTeacher()
        {
            Display(); // from Person
            Console.WriteLine("Subject: " + subject);
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Single Inheritance");
            Student s = new Student();
            s.name = "Alice";
            s.rollNo = 101;
            s.ShowStudent();

            Console.WriteLine("\nMultiple Inheritance (via Interfaces)");
            HobbyStudent hs = new HobbyStudent();
            hs.PlaySport();
            hs.PlayMusic();

            Console.WriteLine("\nMultilevel Inheritance");
            GraduateStudent gs = new GraduateStudent();
            gs.name = "Bob";
            gs.rollNo = 202;
            gs.degree = "BSc Computer Science";
            gs.ShowGraduate();

            Console.WriteLine("\nHierarchical Inheritance");
            Teacher t = new Teacher();
            t.name = "Mr. Ram";
            t.subject = "Math";
            t.ShowTeacher();
        }
    }
}
