using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    // The main program class
    class Program
    {
        // Entry point of the console application
        static void Main(string[] args)
        {
            // Create an Employee object
            // Assign values to firstName and lastName
            Employee employee = new Employee()
        {
            firstName = "Sample",
            lastName = "Student"
        };

            // Call the SayName() method on the employee object
            employee.SayName();

            // Keeps the console window open until a key is pressed
            Console.ReadLine();
        }
    }
}
