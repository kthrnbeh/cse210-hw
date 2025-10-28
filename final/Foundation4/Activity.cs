public abstract class Activity
{
    protected DateTime _date; //changed so I can use it througout all the program
    protected int _minutes; //changed because it wasn't letting me use it. 
    public Activity(DateTime date, int minutes)
    {
        _date = date;
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
    public int GetMinutes()
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
    {
        return $"{_date} {_minutes}"; //placeholder (distance, speed, pace)
    }
        

}