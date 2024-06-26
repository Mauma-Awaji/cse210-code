using System.Net.NetworkInformation;

public class Circle : Shape
{
    private double _radius;
    public Circle(string c, double radius) : base (c)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * _radius  * _radius;
    }
}