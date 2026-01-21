using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsChallenge
{
    class Program
    {

        // Create an enum that represents the days of the week
        enum DaysOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        // Main method where the program starts running
        static void Main(string[] args)
        {
            // Ask the user to enter the current day of the week
            Console.WriteLine("Please enter the current day of the week:");

            // Store the user's input as a string
            string userInput = Console.ReadLine();

            try
            {
                // Attempt to convert (parse) the user's input into the DaysOfWeek enum
                // typeof(DaysOfWeek) tells C# which enum we are parsing
                // true allows case-insensitive input (e.g., monday, MONDAY, Monday)
                DaysOfWeek today = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), userInput, true);

                // If parsing is successful, display the valid day entered
                Console.WriteLine("Happy: " + today);
            }
            catch
            {
                // If the input does not match any enum value,
                // this message will be displayed instead of crashing the program
                Console.WriteLine("Please enter an actual day of the week.");
            }

            // Pause the program so the user can read the output before closing
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
