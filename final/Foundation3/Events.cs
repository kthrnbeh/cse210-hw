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
}