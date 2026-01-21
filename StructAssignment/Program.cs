using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{

    // Define a struct named Number
    // A struct is a value type used to store related data
    struct Number
    {
        // Property named Amount of type decimal
        // Decimal is used for precise numeric values such as money
        public decimal Amount { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of type Number
            Number myNumber = new Number();

            // Assign a decimal value to the Amount property
            myNumber.Amount = 100.50m;

            // Print the Amount value to the console
            Console.WriteLine("The amount is: " + myNumber.Amount);

            // Prevent the console window from closing immediately
            Console.ReadLine();
        }
    }
}
