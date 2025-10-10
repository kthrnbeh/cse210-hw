using System.Security.Cryptography.X509Certificates;

public class Activity
{
    protected string _activity; //I guess I messed this up its supposed to be protected
    protected string _description;
    protected int _time; // accisible to the family
    private Random _random = new Random();
    public Activity(string activity, string description) // my constructor
    { // initialize activity, description, time //if you don't make them call the arg don't put them in()
        _activity = activity;
        _description = description;
        _time = 0;
    }
    public void DisplayStartMessage()
    {
        
        Console.WriteLine($"Welcome to {_activity}!");
        Console.WriteLine($"{_description}");
        Console.Clear();
        //prompt for the duration
        //show spinner 
        //maybe I need a if statement or something
        Console.Write("How long would you like your session (in seconds)? ");
        string input = Console.ReadLine();//move here 
        
        string input = Console.ReadLine();
        if (int.TryParse(input, out int duration) && duration > 0)//always backwards... 
        {
            _time = duration; // reassigning the name 
        }
        else
        {
            Console.WriteLine("Not a valid input, default is to 30 seconds.");
            _time = 30; //assign time for when they give bad input.
            Thread.Sleep(2000);
        }
        Console.Clear(); // clear screen 
        //Console.Write("Ready?");
       // Console.Clear();
       // CountDown(5);
       // Thread.Sleep(1000);
       // StartSpinner(5);
        


    }
    public void DisplayEndMessage()// keep getting confused so changing name. 
    {
        Console.WriteLine("");
        Console.WriteLine("You did it. Good Job. ");
        Console.WriteLine($"You did the {_activity}, for {_time} seconds.");
        StartSpinner(5);
        Console.Clear();
    }
    public void StartSpinner(int seconds)
    {//copy video in assignment // I noticed I have to keep doing seperate date.now in all my other programs. I want to just do it here. 
        List<string> animationstrings = new List<string>();
        animationstrings.Add("|");
        animationstrings.Add("/");
        animationstrings.Add("__");
        animationstrings.Add("\\");
        animationstrings.Add("|");
        animationstrings.Add("/");
        animationstrings.Add("__");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds); // from video
        //int i = 0;
        foreach (string s in animationstrings)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }
        
       // while (DateTime.Now < endTime)
        //{
          //  string s = animationstrings[i % animationstrings.Count]; // apparently use % to help it cycle
         //   Console.Write(s);
           // Thread.Sleep(1000); // original from for
           // Console.Write("\b\b");
           // i++; //remember this from the video
        //}

    }
    public void CountDown(int seconds)
    {
        for (int i = seconds; i <= 0; i--) //want it to go to 5 not 4 add = oops need negatives right.... that was in my notes.
                                           // man I have such dyslexia I always do stuff backwards and opposite! ugh. 
        {
            Console.WriteLine(i);
            Thread.Sleep(1000); // learned from the video in activity
            Console.WriteLine("\b\b");
        }
    }
         public Random GetRandom()
        {
            return _random;
        } //makes use of encapsulation
}     

    

 //https://ironpdf.com/blog/net-help/csharp-tryparse/
//https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators
//https://www.geeksforgeeks.org/c-sharp/constructors-c-sharp/  
//https://www.geeksforgeeks.org/c-sharp/encapsulation-in-c-sharp/
//I really like the geek website
//https://www.w3schools.com/cpp/cpp_date.asp
//https://www.dotnetperls.com/modulo