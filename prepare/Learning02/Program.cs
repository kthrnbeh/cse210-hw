using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks.Dataflow;
//Restarting again after rereading the Activity overview again. //I was confused byt the step 2 _jobTitle
// I need to figure out how to make that work... 
// I was trying to follow the first sample from the reading to help me but it didn;t work.

class Program
{
    static void Main(string[] args)
    {
        // shown in Classes and instances from the reading 
        Console.WriteLine("Hello Learning02 World!");
        job1._jobTitle = "Head Hunter";
        job1._company = "Red Cat Holdings";
        job1._startYear = 2025;
        job1._endYear = 2065;
        job1.Display();

        job2._jobTitle = "Software Engineer";
        job2._company = "Amazon";
        job2._startYear = 2027;
        job2._endYear = 2070;
        job2.Display();
    }
}
class Job //When you create classes, you are really creating a new custom data type.
{
    public string _jobTitle; 
    public string _company;
    public int _startYear;
    public int _endYear;
    Display() : void
    {
        Console.WriteLine($"{_jobTitle} at {_company} from {_startYear} to {_endYear}");
    }

}
Job job1 = new Job();
Job job2 = new Job();
class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();
    Display() : void
    {
        Console.WriteLine($"{_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}