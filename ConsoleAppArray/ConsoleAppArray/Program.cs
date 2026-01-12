using System;
using System.Collections.Generic;


namespace ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array of Strings

            // Create a one-dimensional array of strings

            string[] colorArray = { "Red", "Blue", "Yellow", "Orange", "Green", "Purple", "Black", "White", "Pink", "Brown" };

            // Ask the user to select an index

            Console.WriteLine("Select a number between 0 and 9:");
            int stringSelect = Convert.ToInt32(Console.ReadLine());
            bool validString = false;

            while (!validString)
            {
                try
                {
                    Console.WriteLine("Your favorite color is " + colorArray[stringSelect]);
                    validString = true;
                }

                // Add a message to dispaly if the user picks an index that doesn't exist

                catch
                {
                    Console.WriteLine("Sorry, that number selection is invalid. Please select a number between 0 and 9. ");
                    stringSelect = Convert.ToInt32(Console.ReadLine());

                }
            }

            // List of Strings

            List<string> occupationList = new List<string>()
           {
               "Data Analyst", "UX Designer", "Teacher", "Artist", "Lawyer", "Cowboy", "IT", "Atlete", "Procast Host", "Software Devloper", "QA Tester", "Casher", "Customer Service"
           };

            // Ask the user for a number to display the string at that index

            Console.WriteLine("\nSelect another number between 0 and 9: ");
            int listSelect = Convert.ToInt32(Console.ReadLine());
            bool validList = false;

            while (!validList)
            {
                try
                {
                    Console.WriteLine("Your new occupation is: " + occupationList[listSelect]);
                    validString = true;
                }

                 // Add a message to display if the user picks an index that doesn't exit

                catch
                {
                    Console.WriteLine("Sorry, that number selection is invalid. Please select a number between 0 and 9. ");
                    listSelect = Convert.ToInt32(Console.ReadLine());
                }
            }


        }
    }
}
