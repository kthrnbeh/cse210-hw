public class Lectures : Events
{
    private string _speakerName;
    private int _capacity;
    public Lectures(string _title, string _description, DateTime _date, Timespan _time,string speakerName, int capacity)base:(string _title, string _description, DateTime _date, Timespan _time,)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }
}