public class Activity
{
    private string _activity; //I guess I messed this up its supposed to be private
    private string _description;
    private int _time;
    public Activity(string activity, string description, int time) // my constructor
    { // initialize activity, description, time
        _activity = activity;
        _description = description;
        _time = time;
    }
    public void StartMessageDisplay()
    {
        Console.Clear(); //to clear the screen
        Console.WriteLine("");
        //prompt for the duration
        //show spinner 
        StartSpinner(5);

    }
    public void EndMessageDisplay()
    {
        Console.WriteLine("");
        StartSpinner(5);
        Console.Clear();
    }
    public void StartSpinner(int seconds)
    {//copy video

    }
    public void CountDown(int seconds)
    {

    }

}