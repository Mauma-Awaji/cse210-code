public class Rectangle : Shape
{
    private double _length;
    private double _height;
    public Rectangle(string c, double length, double height) : base (c)
    {
        _length = length;
        _height = height;
    }

    public override double GetArea()
    {
        return _length * _height;
    }
}