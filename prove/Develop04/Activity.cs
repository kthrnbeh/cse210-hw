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
        Console.Clear(); //to clear the screen
        Console.WriteLine($"Welcome to {_activity}!");
        //prompt for the duration
        //show spinner 
        //maybe I need a if statement or something
       
        
    }
    public void EndMessageDisplay()
    {
        Console.WriteLine("");
        StartSpinner(5);
        Console.Clear();
    }
    public void StartSpinner(int seconds)
    {//copy video in assignment
        List<string> animationstrings = new List<string>();
        animationstrings.Add("|");
        animationstrings.Add("/");
        animationstrings.Add("__");
        animationstrings.Add("\\");
        animationstrings.Add("|");
        animationstrings.Add("/");
        animationstrings.Add("__");
        foreach (string s in animationstrings)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }


    }
    public void CountDown(int seconds)
    {
        for (int i = 1; i <= seconds; i++) //want it to go to 5 not 4 add =
        {
            Console.WriteLine(i);
            Thread.Sleep(1000); // learned from the video in activity
        }

         
        

    }

}