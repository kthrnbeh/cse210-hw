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
        int userNumber = -1; // The user won't put a negative number so it can keep going until 0
        while (userNumber !=0) //while the user number is not 0 the user will keep inputting
        {
            Console.Write("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            numbers.Add(number); //We need to add the numbers to the list. 
        }



        
        
    }

}