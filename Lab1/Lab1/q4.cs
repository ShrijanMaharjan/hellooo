using System;
namespace q4
{
    class StudentList
    {
        private string[] names = new string[10]; // max 10 students

        // Indexer to set and get student names by index
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < names.Length)
                    return names[index];
                else
                    throw new IndexOutOfRangeException("Invalid index");
            }
            set
            {
                if (index >= 0 && index < names.Length)
                    names[index] = value;
                else
                    throw new IndexOutOfRangeException("Invalid index");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            StudentList students = new StudentList();

            Console.Write("Enter number of students (max 10): ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.Write($"Enter name of student {i + 1}: ");
                students[i] = Console.ReadLine();
            }

            Console.WriteLine("\nList of Students:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Student {i + 1}: {students[i]}");
            }
        }
    }

}