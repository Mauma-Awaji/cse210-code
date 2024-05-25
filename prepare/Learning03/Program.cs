using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction f1 = new();
        Console.WriteLine($"{f1.GetNumerator()}, {f1.GetDenominator()}");
        Fraction f2 = new(5);
        Console.WriteLine($"{f2.GetNumerator()}, {f2.GetDenominator()}");
        Fraction f3 = new(3,4);
        Console.WriteLine($"{f3.GetNumerator()}, {f3.GetDenominator()}");

        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        f1.SetNumerator(1);
        f1.SetDenominator(3);
        Console.WriteLine($"{f1.GetNumerator()}, {f1.GetDenominator()}");
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        

    }
}