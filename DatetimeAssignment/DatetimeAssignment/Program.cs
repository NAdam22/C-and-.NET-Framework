using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatetimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the current date and time to the console
            DateTime currentDateTime = DateTime.Now; // Stores the current date and time
            Console.WriteLine("Current date and time: " + currentDateTime);

            // Ask the user to enter a number
            Console.WriteLine("Enter a number of hours:"); // Prompts the user for input

            // Read the user's input from the console and convert it to an integer
            int hours = Convert.ToInt32(Console.ReadLine());

            // Calculate the future time by adding the entered number of hours
            DateTime futureDateTime = currentDateTime.AddHours(hours);

            // Print the future date and time to the console
            Console.WriteLine("The date and time in " + hours + " hours will be: " + futureDateTime);

            // Keeps the console window open until the user presses a key
            Console.ReadKey();
        }
    }
}
