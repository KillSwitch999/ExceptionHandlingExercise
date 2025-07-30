using System;
using System.Collections.Generic;
using System.IO;

using System;
using System.Collections.Generic;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) Create a char[] with 6 numbers and 3 letters
            var arr = new char[] { '1', '2', '3', '4', '5', '6', 'a', 'b', 'c' };

            // 2) Create a list to hold integers
            var numbers = new List<int>();

            // 3) Create a string variable initialized as empty
            string str = "";

            // 4) Iterate through the character array
            foreach (var character in arr)
            {
                try
                {
                    // 7) Set the string variable to the current char as a string
                    str = character.ToString();

                    // 8) Parse the string to an int
                    int num = int.Parse(str);

                    // 9) Add parsed int to the list
                    numbers.Add(num);
                }
                catch (Exception)
                {
                    // 11) Handle any parsing errors gracefully
                    Console.WriteLine($"Unable to Parse '{character}'");
                }
            }

            // Print all successfully parsed numbers
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
