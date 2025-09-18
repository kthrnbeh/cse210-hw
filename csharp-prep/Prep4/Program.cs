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
            int number = int.Parse(Console.ReadLine());
            numbers.Add(number); //We need to add the numbers to the list. 
            if (number >= 1) // I want it to add it to the list of things to sum and average. 
            {
                sum += number;
                count += 1; 
                average = (float) sum / count; // add float incase we get a decimal.
            }
            else if (number <= 0) //I want it to stop then print out the total sum and average.
            {
                Console.WriteLine($"The sum is: {sum}");
                Console.WriteLine($"The average is: {average}");
               if (number > Largest) //if the number is the biggest I want it to print out as the max.
            {
                Largest = number;
                Console.WriteLine($"The largest number is: {Largest}"); 
            }
        }



        
        
    }

}