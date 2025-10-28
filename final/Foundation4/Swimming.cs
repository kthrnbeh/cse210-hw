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
        return 0;
    }
    public override double GetSpeed()
    {
        return 0;
    }
}