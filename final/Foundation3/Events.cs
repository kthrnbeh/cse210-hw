public class Events
{
    protected string _title;
    protected string _description;
    protected DateTime _date;
    protected TimeSpan _time;
    protected int _address;

    public Events(string title, string description, DateTime date, TimeSpan time, int address)
    {
        _title = title;
        _description = description;
        _date = date;
        _address = address;
    }
    public string GetTitle()
    {
        return "";
    }
    public void SetTitle()
    {

    }
    public string GetDescription()
    {
        return "";
    }
    public void SetDescription()
    {

    }
    public DateTime GetDateTime()
    {
        return "";
    }
    public void SetDateTime()
    {

    }
    public TimeSpan GetTime()
    {
        return "";
    }
    public void SetTime()
    {

    }
    public int GetAddress()
    {
        return 0;
    }
    public void SetAddress()
    {

    }

    public string SetStandardDetails()
    {
        return "";
    }
    public string GetAllDetails()
    {
        return "";
    }
    public string ShortDescription()
    {
        return "";
    }
    public string EventType()
    {
        return "";
    }

}