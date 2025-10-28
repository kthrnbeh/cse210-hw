public class Running : Activity
{
    private double _distanceMiles;
    public Running(DateTime date, string activity, double minutes, double distanceMiles) : base(date, activity, minutes)
    {
        _distanceMiles = distanceMiles;
    }
    public double GetDistanceMiles()//I really know how to do this part now. 
    {
        return _distanceMiles;
    }
    public void SetDistanceMiles(double distanceMiles)
    {
        _distanceMiles = distanceMiles;
    }
    public override double GetDistance()
    {
        return _distanceMiles;
    }
    public override double GetPace()
    {
        return _minutes / _distanceMiles;
    }
    public override double GetSpeed()
    {
        return (_distanceMiles/ _minutes) *60;
    }
}