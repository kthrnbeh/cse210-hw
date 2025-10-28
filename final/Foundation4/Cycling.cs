public class Cycling : Activity
{
    private double _avgSpeed;
    public Cycling(DateTime date, int minutes, double avgSpeed) : base(date, minutes)
    {
        _avgSpeed = avgSpeed
    }
    public double GetAvgSpeedMPH()
    {
        return _avgSpeed
    }
    public void SetAvgSpeedMPH(double avgSpeed)
    {
        _avgSpeed = avgSpeed;
    }

}