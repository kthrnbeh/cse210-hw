// ok so I need to put all my "fraction class in here"
public class Fraction// doesn't need para...
{
    //My attributes are supposed to be private.. and start_
    private int _top;
    private int _bottom;
    public Fraction()//I fixed the name
    {
        _top = 1;
        _bottom = 1; // apparently integers don't need quotes

    }
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom; // oops
    }
    public int GetTopBottom()
    {
        return _top;
        
    }
    public void SetTopBottom(int top, int bottom)
    {
        _top = top;
        _bottom =bottom;
        

    }
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    
    }
    public double GetDecimalValue() //looked at the reference from learn activity
    {
        return (double)_top / _bottom;
    }
}