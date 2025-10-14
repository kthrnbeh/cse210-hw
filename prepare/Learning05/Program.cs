using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates; // for the list of shapes

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        // TODO: create a list to hold shapes (List<Shape>)
        // example: List<Shape> shapes = new List<Shape>();
        List<Shape> shapes = new List<Shape>();
        Square square = new Square("Square", "blue", 0.9);
        shapes.Add(square);
        Rectangle rect = new Rectangle("Rectangle","Red", .08, .09);
        shapes.Add(rect);
        Circle circle = new Circle("Circle","Purple", 90);
        shapes.Add(circle);
        // TODO: add one of each shape (Square, Rectangle, Circle)
        // each should include color and size values

        // TODO: loop through the list
        // for each shape, display the color and computed area
        // use GetColor() and GetArea()
        //oh like the polymorph video
        foreach (Shape shape in shapes)
        {
            //nothing was happening because I forgot to call my display
            DisplayShapeinfo(shape);
        }

        // TODO: test output to verify polymorphism works correctly
        // (each shape type should calculate its own area)
        //copy like the video



    }
    //oh yeah has to be outside
    public static void DisplayShapeinfo(Shape shape)
    {
        string color = shape.GetColor();
        double area = shape.GetArea();
        string shap = shape.GetType();
        Console.WriteLine($"Shape: {shap}, Color: {color}, Area: {area}");
    }
    
}