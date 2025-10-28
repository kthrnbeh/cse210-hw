public class Cycling: Activity
{
    private double _avgSpeedMPH;
    public Cycling(DateTime date,int minutes,double avgSpeedMPH):base(date,minutes)
    {
        _avgSpeedMPH=avgSpeedMPH
    }
}