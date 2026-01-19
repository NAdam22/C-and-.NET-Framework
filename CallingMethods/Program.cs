using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    // Main Class
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to enter a number
            Console.Write("Enter a number: ");
            int userNumber = int.Parse(Console.ReadLine()); // Convert the input string to an integer

            // Call the DivideByTwo method from the static class
            MathOperations4.DivideByTwo(userNumber);

            // Demonstrate method with an output parameter
            MathOperations4.MultiplyByTwo(userNumber, out int multipliedResult); // Call method with 'out'
            Console.WriteLine($"The number multiplied by 2 using output parameter is: {multipliedResult}");

            // Demonstrate overloaded method
            int product = MathOperations4.MultiplyByTwo(userNumber, 5); // Call overloaded method with two inputs
            Console.WriteLine($"The product of {userNumber} and 5 using overloaded method is: {product}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(); // Wait for user to press a key before closing
        }
    }
}
