public abstract class Shape // base class for all shapes
{
    private string _color; // from diagram (_color : string)
    public Shape(string color)
    {
        _color = color; //added this to get a constructor for the square file
    }

    public string GetColor()
    {
        // TODO: return the color
        return _color;
    }

    public void SetColor(string color)
    {
        // TODO: set the color value (parameter should be a string)
        _color = color;

    }

    public abstract double GetArea(); 
    // TODO: override this method in derived classes (Square, Rectangle, Circle)
    // purpose: calculate and return the area for each shape type
}
