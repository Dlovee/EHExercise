using System;
using System.Collections.Generic;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // Objective: Iterate through a character array. Try to parse each character into an integer.
            // If you attempt to parse a letter into an integer, an exception will occur. 
            // Use a try-catch statement to avoid a run-time exception.
            // Below we will set this up.
            // ------------------------------------------------------------------------------

            // 1) Create a char[], it must contain 6 numbers and 3 letters - name it arr
            var arr = new char[] { '1', '2', '3', '4', '5', '6', 'a', 'b', 'c' };

            // 2) Create a list called numbers that will hold integers
            var numbers = new List<int>();

            // 3) Create a string variable with an empty string initializer - name it str
            var str = "";

            // 4) Make a foreach loop to iterate through your character array            
            foreach (var item in arr)
            {
                try
                {
                    // 7) Set your string variable to each array element in your char[] using .ToString()
                    str = item.ToString();

                    // 8) Now, using int.Parse, parse your string variable and store it in an int variable
                    var number = int.Parse(str);

                    // 9) Then add each int to your list
                    numbers.Add(number);
                }
                catch (Exception e)
                {
                    // 10) Inside the catch block:
                    // 11) In the scope of your catch, use the following code:
                    Console.WriteLine($"Unable to Parse '{item}'");
                }
                finally
                {
                    // Fix: Print actual contents of the list instead of its type
                    Console.WriteLine("Current list contents:");
                    foreach (var num in numbers)
                    {
                        Console.WriteLine(num);
                    }
                }
            }

            // Print final list after parsing all characters
            Console.WriteLine("\nFinal list contents:");
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
