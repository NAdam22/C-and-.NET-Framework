using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to input a number
            Console.WriteLine("Enter a number to perform math operations on:");

            // Read user input as a string and convert it to an integer
            int userNumber = int.Parse(Console.ReadLine());

            // Create an instance of the MathOperations class to use its methods
            MathOperations mathOps = new MathOperations();

            // Call the Square method and display the result
            int squared = mathOps.Square(userNumber);
            Console.WriteLine("The square of your number is: " + squared);

            // Call the Double method and display the result
            int doubled = mathOps.Double(userNumber);
            Console.WriteLine("The double of your number is: " + doubled);

            // Call the AddTen method and display the result
            int addedTen = mathOps.AddTen(userNumber);
            Console.WriteLine("Your number plus 10 is: " + addedTen);

            // Wait for the user to press a key before closing the program
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
