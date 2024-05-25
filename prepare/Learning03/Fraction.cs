using System.Runtime.CompilerServices;

public class Fraction
{
    private int _top;
    private int _bottom;

// constructor to set default values
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    // constructor for taking whole numbers (Denom is set to 1)
    public Fraction(int whole)
    {
        _top = whole;
        _bottom = 1;
    }
    // constructor for taking fractions (Num/Denom)
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

   // Getters for the Numerator and the Denominator
    public int GetNumerator()
    {
        return _top;
    }

    public int GetDenominator()
    {
        return _bottom;
    }

   // Setters for the Numerator and the Denominator
    public void SetNumerator(int num)
    {
        _top = num;
    }

    public void SetDenominator(int den)
    {
        _bottom = den;
    }

    public string GetFractionString()
    {
        string topStr = _top.ToString();
        string bottomStr = _bottom.ToString();     
        return topStr + "/" + bottomStr;
    }

    public double GetDecimalValue()
    {
        double decimVal = (double)_top/_bottom;
        return decimVal;
    }
}