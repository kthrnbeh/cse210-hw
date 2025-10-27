public class Lectures : Events
{
    private string _speakerName;
    private int _capacity;
     // Lecture lecture = new Lecture("AI Summit", "Tech conference", new DateTime(2025, 6, 10), new TimeSpan(10, 0, 0), address1, "Dr. Adams", 200);
    public Lectures(string type,string title, string description, DateTime date, TimeSpan time, Address address,string speakerName, int capacity) : base(type,title, description, date, time, address)
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