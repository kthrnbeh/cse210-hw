public class Square : Shape // derived class from Shape
{
    private double _side; // from diagram (_side : double)

    public Square(string color, double side) : base(color)
    {
        // TODO: set the _side value from the parameter
        // this constructor should call the base class constructor for color
    }

    public override double GetArea()
    {
        // TODO: calculate and return the area of a square
        // formula: side * side
    }
}
