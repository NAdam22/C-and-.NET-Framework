using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    // Main class of the console application
    class Program
    {
        // Main method: entry point of the program
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations2 math = new MathOperations2();

            // Call the first method with an integer and display the result
            int intResult = math.Calculate(15); // 15 + 10 = 25
            Console.WriteLine("Result of integer method: " + intResult);

            // Call the second method with a decimal and display the result
            int decimalResult = math.Calculate(12.5m); // 12.5 * 2 = 25
            Console.WriteLine("Result of decimal method: " + decimalResult);

            // Call the third method with a string that represents an integer and display the result
            int stringResult = math.Calculate("30"); // 30 - 5 = 25
            Console.WriteLine("Result of string method: " + stringResult);

            // Keep the console window open until a key is pressed
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
