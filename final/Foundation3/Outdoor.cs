//Outdoor gatherings, which do not have a limit on attendees, but need to track the weather forecast
public class Outdoor : Events
{
    private string _weatherForcast;
    public Outdoor(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForcast) : base(title, description, date, time, address)
    {
        _weatherForcast = weatherForcast;
    }
    public string GetWeatherForcast()
    {
        return _weatherForcast;
    }
    public void SetWeatherForCast(string weatherForcast)
    {
        _weatherForcast = weatherForcast;
    }
}