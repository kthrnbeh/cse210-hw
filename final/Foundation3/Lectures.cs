public class Lectures : Events
{
    private string _speakerName;
    private int _capacity;
    public Lectures(string speakerName, string title, string description, DateTime date, TimeSpan time, Address address,int capacity) : base(title, description, date, time, address)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }
    public string GetSpeakerName()
    {
        return _speakerName;
    }
    public void SetSpeakerName(string speakerName)
    {
        _speakerName = speakerName;
    }
    public int GetCapacity()
    {
        return _capacity;
    }
    public void SetCapacity(int capacity)
    {
        _capacity = capacity;
    }
  
}