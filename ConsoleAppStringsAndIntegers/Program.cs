using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStringsAndIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list Integers

            List<int> intList = new List<int>() { 5, 99, 23, 10, 185, 22, 12, 2994, 101, 77000 };

            // Ask the user for input and loop through the list

            bool numValid = false;
            while (!numValid)
            {
                // Using a try / catch block to give error message
                
                try
                {
                    Console.WriteLine("\nEnter a number to divide the above list by: ");
                    float numDivide = float.Parse(Console.ReadLine());

                    // if statement to check if the user entered 0

                    if (numDivide == 0)
                    {
                        Console.WriteLine("Please enter a number other than 0. ");

                    }

                    // Dividing each number in the list by the input 

                    else
                    {
                        foreach (int num in intList)
                        {
                            float Divide = num / numDivide;
                            Console.WriteLine(num + "/" + numDivide + " = " + Divide);
                        }
                        numValid = true;
                    }
                }
                // Catch block to dispaly error message for string input

                 catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }   
            }
             // Message to let th user know the program has exited the try / catch block
            Console.WriteLine("The program has exited the try / catch block. ");

            Console.ReadLine();
        }

    }
}
