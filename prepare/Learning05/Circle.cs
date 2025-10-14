public class Circle : Shape // derived class from Shape
{
    private double _radius; // from diagram (_radius : double)

    public Circle(string color,string type, double radius) : base(color,type)
    {
        // TODO: set the _radius value from the parameter
        // this constructor should call the base class constructor for color
        _radius = radius;
    }

    public override double GetArea()
    {
        // TODO: calculate and return the area of a circle
        // formula: Math.PI * radius * radius
        return Math.PI * _radius * _radius;
    }
}
