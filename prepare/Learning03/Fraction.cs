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
        _top = bottom;
    }
    public int GetTopBottom()
    {
        return _top;
        
    }
    public void SetTopBottom(int top)
    {
        _top = top;

    }
    public GetFractionString()
    {
        return _top;
    }
    public GetDecimalValue(int top) //looked at the reference from learn activity
    {
       return(double) _top = top;
    }
}