public class Cycling : Activity
{
    private double _avgSpeed;
    public Cycling(DateTime date,string activity, double minutes, double avgSpeed) :base(date, activity, minutes)
    {
        _avgSpeed = avgSpeed;
    }
    public double GetAvgSpeedMPH()
    {
        return _avgSpeed;
    }
    public void SetAvgSpeedMPH(double avgSpeed)
    {
        _avgSpeed = avgSpeed;
    }
    public override double GetDistance()
    {
        return (_avgSpeed * _minutes) /60;
    }
    public override double GetPace()
    {
        return 60/_avgSpeed;
    }
    public override double GetSpeed()
    {
        return _avgSpeed;
    }

}