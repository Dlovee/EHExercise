using System;
using System.Collections.Generic;
using System.IO;

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
            var arr = new char[] { '1', '2', '3', '4', '5', '6', 'a', 'b', 'c' };
            var numbers = new List<int>();
            var str = "";



            //TODO START HERE:

            // 1) Create an char[], it must contain 6 numbers and 3 letters - name it arr

            // 2) Create a list called numbers that will hold integers

            // 3) Create an string variable with an empty string initializer - name it str

            // 4) Make a foreach loop to iterate through your character array            
            foreach (var item in arr)
            {
                // Creating a try-catch block to catch any exceptions that may occur
                try
                {
                    str = item.ToString();
                    var number = int.Parse(str);
                    numbers.Add(number);
                }
                catch (Exception e)
                {
                    // catching my exceptions
                    Console.WriteLine($"Unable to Parse '{item}'");
                }
                finally
                {
                    Console.WriteLine(numbers);
                }

                foreach (var num in numbers)
                {
                    Console.WriteLine(num);
                }
            }
            // 5) Create a try-catch inide of your foreach loop
            // 6) Inside the try block: 
            // 7) Set your string variable to each array element in your char[] to .ToString()
            // 8) Now, using int.Parse, parse your string variable and store in an int variable
            // 9) Then add each int to your list

            // 10) Inside the catch block:
            // 11) In the scope of your catch you can use the following code:                  
            // Console.WriteLine($"Unable to Parse '{character}'"); //character will be the name of each item in your collection


            // Uncomment the code below to see the numbers you successfully added to the numbers list: 
            //foreach (var num in numbers)
            //{
            //    Console.WriteLine(num);
            //}
        }
    }
}
