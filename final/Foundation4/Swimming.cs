public class Swimming : Activity
{
    private int _laps;
    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }
    public int GetLaps()
    {
        return _laps;
    }
    public void SetLaps(int laps)
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