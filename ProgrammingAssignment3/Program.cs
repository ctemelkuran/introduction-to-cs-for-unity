using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment3
{
    // IMPORTANT: Only add code in the section
    // indicated below. The code I've provided
    // makes your solution work with the 
    // automated grader on Coursera

    /// <summary>
    /// Programming Assignment 3
    /// </summary>
    class Program
    {
        // number to classify
        static int number;

        /// <summary>
        /// Classifies numbers as even or odd and negative, 0, or positive
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // loop while there's more input
            string input = Console.ReadLine();
            while (input[0] != 'q')
            {
                // extract number from string
                int value = GetInputValueFromString(input);


                if (value % 2 == 0)
                {
                    Console.Write("e" + " ");
                    if (value > 0)
                        Console.WriteLine("1");
                    else if (value == 0)
                        Console.WriteLine("0");
                    else
                        Console.WriteLine("-1");
                }
                else if (value % 2 == 1 || value % 2 == -1)
                {
                    Console.Write("o" + " ");
                    if (value > 0)
                        Console.WriteLine("1");
                    else if (value == 0)
                        Console.WriteLine("0");
                    else
                        Console.WriteLine("-1");
                }



                    // Don't add or modify any code below
                    // this comment
                    input = Console.ReadLine();
            }
        }

        /// <summary>
        /// Extracts the number from the given input string
        /// </summary>
        /// <param name="input">input string</param>
        static int GetInputValueFromString(string input)
        {
            number = int.Parse(input);
            return number;
        }
    }
}
