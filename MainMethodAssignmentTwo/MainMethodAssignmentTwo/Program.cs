using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignmentTwo
{
    // Main program class
    class Program
    {
        // Main method - entry point of the console application
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations3 mathOp = new MathOperations3();

            // Ask the user to input the first number
            Console.Write("Enter the first number: ");
            // Read the user's input, convert it to an integer, and store in firstNumber
            int firstNumber = int.Parse(Console.ReadLine());

            // Ask the user to input the second number (optional)
            Console.Write("Enter the second number (optional, press Enter to skip): ");
            // Read the user's input
            string input = Console.ReadLine();

            int result; // Variable to store the result

            // Check if the user entered something for the second number
            if (string.IsNullOrEmpty(input))
            {
                // Call the method with only the first number
                result = mathOp.MultiplyNumbers(firstNumber);
            }
            else
            {
                // Convert the second number input to integer
                int secondNumber = int.Parse(input);
                // Call the method with both numbers
                result = mathOp.MultiplyNumbers(firstNumber, secondNumber);
            }

            // Display the result to the user
            Console.WriteLine($"The result is: {result}");

            // Wait for the user to press a key before closing the console
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
