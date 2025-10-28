public class Swimming : Activity
{
    private double _laps;
    public Swimming(DateTime date,string activity, int minutes, double laps) : base(date,activity, minutes)
    {
        _laps = laps;
    }
    public double GetLaps()
    {
        return _laps;
    }
    public void SetLaps(double laps)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        double distance = (_laps * 50) / 1000;
        return distance;
    }
    public override double GetPace()
    {
        double pace = _minutes / miles;
        return pace; //have to get the distance first to calculate this
    }
    public override double GetSpeed()
    {
        double miles = GetDistance();
        double speed = (miles / _minutes) * 60.0;
        return speed;
    }
}