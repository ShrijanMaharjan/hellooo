using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of students: ");
        int count = int.Parse(Console.ReadLine());

        int[] studentMarks = new int[count];

        for (int i = 0; i < count; i++)
        {
            Console.Write($"Enter marks for student {i + 1}: ");
            studentMarks[i] = int.Parse(Console.ReadLine());
        }

        // Deferred execution query
        IEnumerable<int> highScorersQuery = studentMarks.Where(mark => mark > 80);

        Console.WriteLine("\nThe marks greater than 80 are:");

        // Query executes here (deferred execution)
        foreach (int mark in highScorersQuery)
        {
            Console.WriteLine(mark);
        }

        // Count executes the query again
        int highScorerCount = highScorersQuery.Count();
        Console.WriteLine($"\nTotal students who scored more than 80: {highScorerCount}");
    }
}
