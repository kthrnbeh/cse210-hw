using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        //Prep 3 Guess My Number
        //Console.Write("What is the magic number?");
        //int magicNumber = int.Parse(Console.ReadLine()); //Part 1 ask user what the magic number is
        Random randomGenerator = new Random();
        //int magicNumber = randomGenerator.Next(1, 101); //Part three random number generator.
        //int guessCount = 0; //stretch keep track of the users number of guesses.
        //Console.Write("What is your guess?");
        //int userGuess = int.Parse(Console.ReadLine());
        //guessCount++; //Stretch count the first guess.
        string response;     //Stretch task two ask user if they want to play again.

    do
    {
            //asked Chat why my code wasn't working and it explained to put it inside do, 
            //I agreed because your proram showed to put the needed code inside the while
        
        
        int magicNumber = randomGenerator.Next(1, 101); //Part three random number generator.
        int guessCount = 0; //stretch keep track of the users number of guesses.

        Console.Write("What is your guess?");
        int userGuess = int.Parse(Console.ReadLine());
        guessCount++; //Stretch count the first guess.
    
         while (userGuess != magicNumber) // Part two add while look. //Updated from user guess to random
        {
            if (userGuess < magicNumber) // Part 1 ask until get the proper answer. //updated to random 
            {
                Console.WriteLine("Higher");
                guessCount++; //Stretch guess counter.
            }
            else
            {
                Console.WriteLine("Lower");
                guessCount++;
            }
            Console.Write("What is your guess?");
            userGuess = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("You guessed it!");
        guessCount++; //Stretch count the final guess.
        Console.WriteLine($"It took you {guessCount} guesses."); //Stretch print the number of guesses.
            Console.Write("Do you want to continue playing? (yes/no)");
        response = Console.ReadLine();
    } while (response == "yes");
        

    } //It took so much help for the strech part so if I don't get credit for that makes sense. I now learned though how to do it and am glad to save it!
}