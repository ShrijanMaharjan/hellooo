using System;

class Program
{
    static void Main()
    {
        // Initial string
        string original = "Hello";
        Console.WriteLine("Original string: " + original);

        // Attempt to change the string using concatenation
        string modified = original + " World";

        // Display both strings
        Console.WriteLine("Modified string: " + modified);
        Console.WriteLine("Original string after modification attempt: " + original);

        // Check if the references are same
        Console.WriteLine("Are both references equal? " + Object.ReferenceEquals(original, modified));
    }
}
