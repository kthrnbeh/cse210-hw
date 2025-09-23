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
class Job
{
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;
    


}