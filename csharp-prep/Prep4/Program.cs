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
        int userNumber = -1;
        while (userNumber != 0) //while the user number is not 0 the user will keep inputting
        {
            Console.Write("Enter a number:");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber == 0) // what happens if the user puts 0 I need it to check that first! ok. Figuring it out.
            {
                break;  
            }
            else
            {
                numbers.Add(userNumber); // I was adding the number to the list before checking if it was 0. Opps! 
            }
        if (numbers.Count > 0)
        {
            int sum = 0;
            float average = 0f;
            int Largest = numbers[0];
            foreach (int n in numbers)
            {
                sum += n;

                if (n > Largest)
                {
                    Largest = n;

                }
            }
            average = (float)sum / numbers.Count;
            Largest = numbers[0];
           
                    
                }
                Console.WriteLine($"The sum is: {sum}");
                Console.WriteLine($"The average is: {average}"); //I had to cast sum to a float to get the decimal answer.
                Console.WriteLine($"The Largest number is: {Largest}"); //finding tips from the example
            
                
                
            
            }
        }



        
        
    }

}