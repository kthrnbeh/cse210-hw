public abstract class Activity
{
    protected DateTime _date; //changed so I can use it througout all the program
    protected string _activity;
    protected int _minutes; //changed because it wasn't letting me use it. 
    public Activity(DateTime date, string activity,int minutes)
    {
        _date = date;
        _activity = activity;
        _minutes = minutes;
    }
    public DateTime GetDate()
    {
        return _date;
    }
    public void SetDate(DateTime date)
    {
        _date = date;
    }
    public string GetActivity()
    {
        return _activity;
    }
    public void SetActivity(string activity)
    {
        _activity = activity;
    }
    public double GetMinutes()
    {
        return _minutes;
    }
    public void SetMinutes(int minutes)
    {
        _minutes = minutes;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
     public abstract double GetPace();
    public string GetSummary()
    {  //got to add a datetime thing like last time. 
        //03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();
        string summary = $"{_date.ToShortDateString()} {_activity} ({_minutes}min) - Distance {distance} miles, Speed {speed} mph, Pace {pace} min per mile"; //placeholder (distance, speed, pace)
        return summary;
    }
        

}