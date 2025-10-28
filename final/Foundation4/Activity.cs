public abstract class Activity
{
    private DateTime _date;
    private int _minutes;
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

}