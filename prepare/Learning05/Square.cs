using System.Formats.Asn1;
using System.Reflection.Metadata.Ecma335;

public class Square : Shape
{
    private double _side;
    public Square(string c, double side) : base (c)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return Math.Pow(_side,2);
    }
}