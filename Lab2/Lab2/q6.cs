using System;
namespace q6
{

    // Define a custom exception
    public class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message) : base(message)
        {
        }
    }

    class Program
    {
        static void Main()
        {
            try
            {
                // Read balance from user
                Console.Write("Enter account balance: ");
                double balance = Convert.ToDouble(Console.ReadLine());

                // Read withdrawal amount from user
                Console.Write("Enter withdrawal amount: ");
                double withdraw = Convert.ToDouble(Console.ReadLine());

                // Check balance
                if (withdraw > balance)
                {
                    // Throw custom exception
                    throw new InsufficientBalanceException("Withdrawal failed: Insufficient balance.");
                }

                // Calculate and display remaining balance
                double remaining = balance - withdraw;
                Console.WriteLine($"Withdrawal successful! Remaining balance: {remaining}");
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter valid numeric values.");
            }
        }
    }
}