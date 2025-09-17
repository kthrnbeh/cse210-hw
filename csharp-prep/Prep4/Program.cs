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
        //Create list to hold numbers 
        List<int> numbers = new List<int>();
        int sum = 0; // I guess I do need to declare sum outside the loop first.
        float average = 0.0f; // As well as average
        int max = int.MinValue; // I had to google this one.
        int userInput = -1; 
        while (userInput != 0)
        {
            Console.Write("Enter number: (0 quits)");
            userInput = int.Parse(Console.ReadLine());
            if (userInput != -1)
            {
                numbers.Add (userInput); //append new numbers to the list from the user
                sum += userInput; //I want to add number together as they get added.
                Console.WriteLine($"The sum is: {sum}");

            }
            
            
            average = (float)sum / numbers.Count; // average I have a bit of a harder time with this ones code.
            Console.WriteLine($"The average is: {average}");
           int maxNum = numbers[0];
           for (int i = 1; i < numbers.Count; i++) {
               if (numbers[i] > maxNum) {
                   maxNum = numbers[i]; // Had to google this one.// it took me almost an hour to figure this one.. 
                   Console.WriteLine($"The largest number is: {maxNum}");
               }

        }

        
        ;
    }

}