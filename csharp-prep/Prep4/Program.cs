using System;
using System.Collections.Generic; // remember this  

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello prep4 "); // To remind me this is prep 4 
        Console.WriteLine("Hello User, Enter a list of numbers, type 0 when finished.");
        //this is prep 4 
        //I am restarting. This is very difficult for me for some reason.
        //Ask the user for a series of numbers, and append each one to a list. Stop when they enter 0.

        
        List<int> numbers = new List<int>();
        int userNumber = -1; // start not-0 so loop runs

        while (userNumber != 0) // while the user number is not 0 the user will keep inputting
        {
            Console.Write("Enter a number: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber == 0) // what happens if the user puts 0 I need it to check that first! ok. Figuring it out.
            {
                break; // stop if user enters 0
            }
            else
            {
                numbers.Add(userNumber);// I was adding the number to the list before checking if it was 0. Opps! 
            }
        }

        
        if (numbers.Count > 0)
        {
            float sum = 0;
            float average = 0f;
            float Largest = numbers[0]; // apparently if I want to do a decimal answer I need to add the word float here

            foreach (int n in numbers)
            {
                sum += n;

                if (n > Largest)
                {
                    Largest = n;
                }
            }

            average = (float)sum / numbers.Count;

            Console.WriteLine($"The sum is: {sum}"); 
            Console.WriteLine($"The average is: {average}");//add float incase I get a user decimal. or decimal answer
            Console.WriteLine($"The Largest number is: {Largest}"); // finding tips from the example 
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }   
  } // closes Main
} // closes Pro