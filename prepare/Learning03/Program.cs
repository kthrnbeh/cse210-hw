using System;

class Program
{
    //Create a class to hold Fractions //a bit confused about the file instruction
    //asked for clarity and figured out it meant make its own.. file. It's own cs. 
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction f = new Fraction();
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(6, 7);
        Fraction f = new Fraction()
        Console.WriteLine(f.GetFractionString());
        Console.WriteLine(f.GetDecimalValue());

    }
    // do I call the fraction class here? I will try and see if it works
    public GetFractionString()
    {
        return _top;
    }
    public GetDecimalValue(int top) //looked at the reference from learn activity
    {
        _top = top;
    }
    // Now it wants me to do something like this
    //Person p = new Person();
    //p.SetFirstName("Peter");

//Console.WriteLine(p.GetFirstName());
    
}