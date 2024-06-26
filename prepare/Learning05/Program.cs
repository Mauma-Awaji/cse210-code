using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        List<Shape> shapes = new();
        Square square = new("red", 7);
        Rectangle rectangle = new("blue", 6, 4);
        Circle circle = new("yellow", 7);
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The {shape}'s color is {shape.GetColor()}");
            Console.WriteLine($"The {shape}'s area is {shape.GetArea()}");
        }




    }
}