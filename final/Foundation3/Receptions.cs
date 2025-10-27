public class Receptions : Events
{
    private string _RSVP;

    public Receptions(string title, string description, DateTime date, TimeSpan time,Address address,string RSVP):base(title,description,date,time,address)
    {
        _RSVP = RSVP;

    }
    public string GetRSVP()
    {
        return _RSVP;
    }
    public void SetRSVP(string RSVP)
    {
        _RSVP = RSVP;
    }

}