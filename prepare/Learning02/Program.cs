using System;
using System.Collections.Generic;


//Following the instructions from the Abstraction overview //I am trying to create a workin thing hope this is right.
class Job
{
    //Step 3 ? Should these be moved up here? 
    public string Company;
    public string Jobtitle;
    public int Startyear;
    public int Endyear;
    public string Name;
    public List<Job> Jobs;

    //Step 1: You program should contain two classes one for a Job and one for the Resume itself
    // this is step 3 actually making it public. 
    public class Job(string company, string jobTitle, int startYear, int endYear) // the second word should be capalized oh yeah. 
    {
        Company = company;
        Jobtitle = jobTitle;
        Startyear = startYear;
        Endyear = endYear;
    }
    // Ugh thi
    public class Resume(string name, List<Job> jobs)
    {
        Name = name;
        Jobs = jobs;
     }
        
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        job1._jobTitle = "Software Engineer";
    }
}


}