using System;
namespace q3
{
    interface IOperation
    {
        double Calculate(double a, double b);
    }

    // Addition class
    class Addition : IOperation
    {
        public double Calculate(double a, double b)
        {
            return a + b;
        }
    }

    // Subtraction class
    class Subtraction : IOperation
    {
        public double Calculate(double a, double b)
        {
            return a - b;
        }
    }

    // Multiplication class
    class Multiplication : IOperation
    {
        public double Calculate(double a, double b)
        {
            return a * b;
        }
    }

    // Division class
    class Division : IOperation
    {
        public double Calculate(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: Division by zero!");
                return double.NaN;
            }
            return a / b;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            IOperation add = new Addition();
            IOperation sub = new Subtraction();
            IOperation mul = new Multiplication();
            IOperation div = new Division();

            Console.WriteLine("\nResults:");
            Console.WriteLine($"Addition: {add.Calculate(num1, num2)}");
            Console.WriteLine($"Subtraction: {sub.Calculate(num1, num2)}");
            Console.WriteLine($"Multiplication: {mul.Calculate(num1, num2)}");
            Console.WriteLine($"Division: {div.Calculate(num1, num2)}");
        }
    }
}
