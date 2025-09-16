using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        //The program awards the letter grade for User as they put in there score.

        {
            Console.Write("Please enter your test score:");
            string score = Console.ReadLine();
            int letter = int.Parse(score);
            string grade = " ";
            if (letter >= 90) // I made two mistakes here first I used numbers to  compare instead of letter
            {
                grade = "A"; //second I didn't remember how to comment and used # instead of //
            }
            else if (letter >= 80) // I inquired the web with how to comment in c+
            {
                grade = "B"; //Then asked chatGPT to teach me what I did wrong on the first if statement.
            }
            else if (letter >= 70)
            {
                grade = "C";
            }
            else if (letter >= 60)
            {
                grade = "D";
            }
            else
            {
                grade = "F"; // I also saw I used score instead of the word letter.I updated that.
            }
            Console.WriteLine($"Your Letter Grade is {grade}."); //Prints letter grade.
                                                                 // my statement kept printing the score  not grade. I had to look up what I did wrong. I asked to be taught what to do. 
                                                                // After I was like "Oh yeah I learned that in python... I just forgot." 
        }
        
    }
}