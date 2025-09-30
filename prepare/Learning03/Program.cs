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
        f2.SetTopBottom(3,8);
        f3.SetTopBottom(10,7);
        Console.WriteLine(f);
        
        Console.WriteLine(f2.GetDecimalValue());
        Console.WriteLine(f3.GetDecimalValue());


    }
    // do I call the fraction class here? I will try and see if it works
    // Now it wants me to do something like this
    //Person p = new Person();
    //p.SetFirstName("Peter");

//Console.WriteLine(p.GetFirstName());
    
}