using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    // Create a class named MathOperations 2
    public class MathOperations2
    {
        // First method: takes an integer, adds 10, and returns the result
        public int Calculate(int number)
        {
            // Perform addition operation
            int result = number + 10;
            // Return the result as an integer
            return result;
        }

        // Second method (overloaded): takes a decimal, multiplies by 2, and returns as integer
        public int Calculate(decimal number)
        {
            // Perform multiplication operation
            int result = (int)(number * 2); // Convert decimal result to integer
                                            // Return the result
            return result;
        }

        // Third method (overloaded): takes a string, converts to integer, subtracts 5, and returns
        public int Calculate(string numberString)
        {
            // Try to convert the string to an integer
            if (int.TryParse(numberString, out int number))
            {
                // Perform subtraction operation
                int result = number - 5;
                // Return the result
                return result;
            }
            else
            {
                // If conversion fails, return 0 and display message
                Console.WriteLine("Invalid string input. Cannot convert to integer.");
                return 0;
            }
        }
    }
}
