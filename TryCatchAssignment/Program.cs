using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Wrap the entire logic in a try block to catch any runtime errors
            try
            {
                // Ask the user to enter their age
                Console.WriteLine("Please enter your age:");

                // Read the user input as a string and convert it to an integer
                int age = Convert.ToInt32(Console.ReadLine());

                // Check if the age is zero or a negative number
                if (age <= 0)
                {
                    // Throw an exception if the age is not valid
                    throw new ArgumentException("Age must be a positive number greater than zero.");
                }

                // Get the current year from the system
                int currentYear = DateTime.Now.Year;

                // Calculate the year the user was born
                int birthYear = currentYear - age;

                // Display the calculated birth year to the user
                Console.WriteLine("You were born in the year: " + birthYear);
            }
            // Catch block for invalid age values (zero or negative numbers)
            catch (ArgumentException ex)
            {
                // Display the specific error message
                Console.WriteLine(ex.Message);
            }
            // Catch block for any other unexpected errors
            catch (Exception)
            {
                // Display a general error message
                Console.WriteLine("An error occurred. Please enter a valid number.");
            }
            // Keeps the console window open until the user presses a key
            finally
            {
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }
        }
    
    }
}
