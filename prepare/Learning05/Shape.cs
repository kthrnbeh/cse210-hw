public abstract class Shape // base class for all shapes
{
    private string _color; // from diagram (_color : string)
    private string _shapeType;
    public Shape(string type, string color)
    {
        _color = color; //added this to get a constructor for the square file
        _shapeType = type;
    }   
    
    public void SetType(string type)
    {
        _shapeType = type;
    }
    public string GetType()
    {
        return _shapeType;
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
