public class Running : Activity
{
    private double _distance;
    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }
    public double GetDistance()//I really know how to do this part now. 
    {
        return _distance;
    }
    public void SetDistance(double distance)
    {
        _distance = distance;
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