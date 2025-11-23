using System;
using System.Linq;
namespace q4
{
    class Program
    {
        static void Main()
        {
            // Take input string from the user
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            // Remove spaces for counting (optional)
            var cleanedInput = input.Replace(" ", "");

            // Use LINQ to group characters and count frequency
            var frequency = cleanedInput
                            .GroupBy(c => c)
                            .Select(g => new { Character = g.Key, Count = g.Count() });

            // Display results
            Console.WriteLine("\nCharacter Frequencies:");
            foreach (var item in frequency)
            {
                Console.WriteLine($"Character '{item.Character}' occurs {item.Count} time(s)");
            }
        }
    }
}
