public class Rectangle : Shape // derived class from Shape
{
    private double _length; // from diagram (_length : double)
    private double _width;  // from diagram (_width : double)

    public Rectangle(string color, double length, double width) : base(color)
    {
        // TODO: set both _length and _width from the parameters
        // this constructor should call the base class constructor for color
    }

    public override double GetArea()
    {
        // TODO: calculate and return the area of a rectangle
        // formula: length * width
    }
}
