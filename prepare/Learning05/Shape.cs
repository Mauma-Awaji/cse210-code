using System.Drawing;
using System.Formats.Asn1;

public abstract class Shape
{
    private string _color;

    // public Shape()
    // {
    // }
    public Shape(string c)
    {
        _color = c;
    }
    public void SetColor(string c)
    {
        _color = c;
    }

    public string GetColor()
    {
        return _color;
    }

    public abstract double GetArea();
  
}