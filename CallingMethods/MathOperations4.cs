using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    // Declare a static class
    static class MathOperations4
    {
        // Void method that takes an integer, divides it by 2, and prints the result
        public static void DivideByTwo(int number)
        {
            int result = number / 2; // Divide the input number by 2 and store in result
            Console.WriteLine($"The number divided by 2 is: {result}"); // Print the result
        }

        // Method with an output parameter
        public static void MultiplyByTwo(int number, out int result)
        {
            result = number * 2; // Multiply the input number by 2 and set it as the output parameter
        }

        // Overloaded method: takes two integers and adds them
        public static int MultiplyByTwo(int number1, int number2)
        {
            return number1 * number2; // Return the product of two numbers
        }
    }
}
