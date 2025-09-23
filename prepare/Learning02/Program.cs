using System;
using System.Collections.Generic;


//Restarting again after rereading the Activity overview again. //I was confused byt the step 2 _jobTitle
// I need to figure out how to make that work... 
// I was trying to follow the first sample from the reading to help me but it didn;t work.

class Program
{
    static void Main(string[] args)   //void = means it doesn’t return anything.
    //string[] args = an array of strings you could pass in from the command line (you don’t need it now, but it’s required by convention).
    {
        // shown in Classes and instances from the reading 
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job(); //Thought I was done but wouldn't run so compared to example to see what I did wrong.
        job1._jobTitle = "Head Hunter";
        job1._company = "Red Cat Holdings";
        job1._startYear = 2025;
        job1._endYear = 2065;
        job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "Amazon";
        job2._startYear = 2027;
        job2._endYear = 2070;
        job2.Display();

        // apperently my job2 and two were outside the main method so I deleted them. So I can figure out what to do. 
        //Following your simple answer for the Resume 
        //I asked the internet why your code works and what to explain each aspect so I can relate it to the reading. I truly want to learn this stuff. 
        //especially to learn how to make my code more simple.
        Resume personalResume = new Resume();
        personalResume._name = "Adam Magistri"
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
      
    }
}


