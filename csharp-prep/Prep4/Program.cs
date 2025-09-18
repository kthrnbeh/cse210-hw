using System;
using System.Collections.Generic; // remember this  

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello prep4 "); //To remind me this is prep 4 
        //I am restarting. This is very difficult for me for some reason.
        //Ask the user for a series of numbers, and append each one to a list. Stop when they enter 0.
        Console.WriteLine("Hello User, Enter a list of numbers, type 0 when finished.");
        //Once you have a list, have your program do the following:
        List<int> numbers = new List<int>();
        //Declaring the variables above the loop that I will need, I forgot.
        int sum = 0;
        int count = 0;
        float average = 0f;
        int Largest = int.MinValue; 
        int userNumber = -1; // The user won't put a negative number so it can keep going until 0
        while (userNumber != 0) //while the user number is not 0 the user will keep inputting
        {
            Console.Write("Enter a number:");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0) // what happens if the user puts 0 I need it to check that first! ok. Figuring it out.
            {
                break;  
            }
            numbers.Add(userNumber);// I was adding the number to the list before checking if it was 0. Opps! 
            if (userNumber >= 1) // I want it to add it to the list of things to sum and average. 
            {
                sum += userNumber;
                count += 1; 
                average = (float) sum / count; // add float incase we get a decimal.
            }
            else if (userNumber <= 0) //I want it to stop then print out the total sum and average.
            {
                Console.WriteLine($"The sum is: {sum}");
                Console.WriteLine($"The average is: {average}");
            }
            if (userNumber > Largest) //if the number is the biggest I want it to print out as the max.
            {
                Largest = userNumber;
                Console.WriteLine($"The largest number is: {Largest}"); 
            }
        }



        
        
    }

}