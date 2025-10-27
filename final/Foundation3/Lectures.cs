public class Lectures : Events
{
    private string _speakerName;
    private int _capacity;
    public Lectures(string speakerName, int capacity)base:()
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }
}