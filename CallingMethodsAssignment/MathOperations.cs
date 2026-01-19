using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    // This class contains three methods that each perform a different math operation
    public class MathOperations
    {
        // Method 1: Squares the input number
        public int Square(int number)
        {
            return number * number; // Multiply the number by itself and return the result
        }

        // Method 2: Doubles the input number
        public int Double(int number)
        {
            return number * 2; // Multiply the number by 2 and return the result
        }

        // Method 3: Adds 10 to the input number
        public int AddTen(int number)
        {
            return number + 10; // Add 10 to the number and return the result
        }
    }
}
