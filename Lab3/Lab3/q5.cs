using System;
using System.Collections.Generic;
using System.Linq;
namespace q5
{
    class Program
    {
        static void Main()
        {
            // Sample list of cities
            List<string> cities = new List<string>
        {
            "ROME", "LONDON", "NAIROBI", "CALIFORNIA",
            "ZURICH", "NEWDELHI", "AMSTERDAM", "ABUDHABI", "PARIS"
        };

            Console.Write("Enter the specific character: ");
            char ch = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine("\n");

            // LINQ query to filter cities
            var result = cities
                .Where(city => city.StartsWith(ch.ToString()) && city.EndsWith(ch.ToString()))
                .ToList();

            if (result.Any())
            {
                Console.WriteLine("Cities that start and end with '{0}':", ch);
                result.ForEach(Console.WriteLine);
            }
            else
            {
                Console.WriteLine("No cities found that start and end with '{0}'.", ch);
            }
        }
    }
}
