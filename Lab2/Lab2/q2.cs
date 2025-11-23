using System;
namespace q2
{
    class Program
    {
        // Define a delegate that takes two integers and returns an integer
        public delegate int AddDelegate(int a, int b);

        // Method that matches the delegate signature
        public static int Add(int x, int y)
        {
            return x + y;
        }

        static void Main()
        {
            // Create an instance of the delegate and assign the Add method
            AddDelegate addDelegate = new AddDelegate(Add);

            // Input two digits
            Console.Write("Enter first digit: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second digit: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Use delegate to call the Add method
            int result = addDelegate(num1, num2);

            // Output the result
            Console.WriteLine("Sum = " + result);
        }
    }
}
