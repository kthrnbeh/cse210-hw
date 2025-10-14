public class Circle : Shape // derived class from Shape
{
    private double _radius; // from diagram (_radius : double)

    public Circle(string color, double radius) : base(color)
    {
        // TODO: set the _radius value from the parameter
        // this constructor should call the base class constructor for color
    }

    public override double GetArea()
    {
        // TODO: calculate and return the area of a circle
        // formula: Math.PI * radius * radius
    }
}
