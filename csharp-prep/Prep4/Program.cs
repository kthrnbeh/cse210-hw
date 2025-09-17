using System;
using System.Collections.Generic; // remember this  

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        // For this prep 4 Ask the user for a series of numbers, and append each one to a list. Stop when they enter 0.
        // ask user for a number 
        Console.Write("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter number: ");
        int userInput = int.Parse(Console.ReadLine()); // For a sec I forgot to add this. Good thing I checked the assignment.
        //Create list to hold numbers 
        List<int> numbers = new List<int>();
        //Now I need to append a series of numbesrs to the list until they enter 0.
        //Compute the sum, or total, of the numbers in the list.
        int sum = 0;
        //Compute the average of the numbers in the list.
        float average = 0.0f;
        //Find the maximum, or largest, number in the list.
        int max = int.List<int>.Max();
        //Create while Loop and then get results to all the above.
        while (userInput != 0)
        {
            numbers.Add(userInput); //append new numbers to list from user
            Console.Write("Enter number:");
            userInput = int.Parse(Console.ReadLine());
            sum += userInput; //I want to add number together as they get added. 
            average = (float)sum / numbers.Count; // average I have a bit of a harder time with this ones code.
            max = Math.Max(max, userInput); // Had to google this one. 

        }

        Console.WriteLine($ "The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }

}