public class Swimming : Activity
{
    private double _laps;
    public Swimming(DateTime date,string activity, double minutes, double laps) : base(date,activity, minutes)
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
        return (_laps*50)/1000;
    }
    public override double GetPace()
    {
        return (_minutes/GetDistance()); //have to get the distance first to calculate this
    }
    public override double GetSpeed()
    {
        return (GetDistance()/_minutes)* 60;//and this
    }
}