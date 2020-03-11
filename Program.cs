using System;

namespace Madcat_v25
{
    class Program
    {
        static void Replicate(int idealNum, string thoughts, string seperator)
        {
            // Output value to update every last value obtained from the for loop.
            string output = "";

            // Initiating for loop to be used when invoked by Main method.
            for (int i = 0; i < idealNum; i++)
            {
                // For the iteration equal to the ideal number minus 1, update output without the seperator.
                if (i == idealNum - 1)
                    output = output + thoughts;
                // For each iteration not equal to the ideal number minus 1, update output with seperator.
                else
                    output = output + thoughts + seperator;
            }
            
            // Write out the output created from above on console. 
            Console.WriteLine(output);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Nahisha Nobregas Version = 25");

            // Initiating variables.
            string thoughts;
            int idealNum;
            string seperator;

            // Asking user to enter a string of characters as word or phrase.
            Console.WriteLine("Please enter a word or phrase.\t\t");
            thoughts = Console.ReadLine();

            // Asking user to enter a number between 2 and 5.
            Console.WriteLine("\n\nEnter a number between 2 and 5.\t\t");
            idealNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\nEnter a seperator for the prints.\t\t");
            seperator = Console.ReadLine();
            Replicate(idealNum, thoughts, seperator);

        }
    }
}
