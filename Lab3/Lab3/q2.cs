using System;
using System.Linq;
namespace q2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            var uppercaseLetters = input.Where(char.IsUpper);

            Console.WriteLine("\nUppercase letters in the string:");
            foreach (char c in uppercaseLetters)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine($"\n\nTotal uppercase letters: {uppercaseLetters.Count()}");
        }
    }
}
