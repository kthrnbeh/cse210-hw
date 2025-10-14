public abstract class Shape // base class for all shapes
{
    private string _color; // from diagram (_color : string)

    public string GetColor()
    {
        // TODO: return the color
    }

    public void SetColor()
    {
        // TODO: set the color value (parameter should be a string)
    }

    public abstract double GetArea(); 
    // TODO: override this method in derived classes (Square, Rectangle, Circle)
    // purpose: calculate and return the area for each shape type
}
