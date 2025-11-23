using System;
using System.Linq;
namespace q3
{
    class Program
    {
        static void Main()
        {
            // Take input from the user
            Console.Write("Enter numbers separated by spaces: ");
            string input = Console.ReadLine();

            // Convert input to integer array
            int[] numbers = input.Split(' ')
                                 .Select(int.Parse)
                                 .ToArray();

            // Use LINQ to calculate squares
            var squares = numbers.Select(n => new { Number = n, Square = n * n });

            // Display results
            Console.WriteLine("\nSquares of the numbers:");
            foreach (var item in squares)
            {
                Console.WriteLine($"Square of Number {item.Number} is {item.Square}");
            }
        }
    }
}
