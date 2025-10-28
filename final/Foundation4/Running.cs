public class Running : Activity
{
    private double _distanceMiles;
    public Running(DateTime date, int minutes, double distanceMiles) : base(date, minutes)
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
        return 0;
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