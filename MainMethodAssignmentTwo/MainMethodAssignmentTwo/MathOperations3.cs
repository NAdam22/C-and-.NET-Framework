using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignmentTwo
{
    // Define a class named MathOperations
    class MathOperations3
    {
        // Method that takes two integers. The second integer is optional and defaults to 1
        public int MultiplyNumbers(int num1, int num2 = 1)
        {
            // Multiply the two numbers and return the result
            return num1 * num2;
        }
    }
}
