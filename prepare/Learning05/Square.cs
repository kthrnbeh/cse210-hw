using System.Reflection.Metadata.Ecma335;

public class Square : Shape // derived class from Shape
{
    private double _side; // from diagram (_side : double)

    public Square(string color, string type, double side) : base(color, type)
    {
        // TODO: set the _side value from the parameter
        // this constructor should call the base class constructor for color
        _side = side;
        
    }

    public override double GetArea()
    {
        // TODO: calculate and return the area of a square
        // formula: side * side
        return _side * _side;
    }
}
//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/using-constructors