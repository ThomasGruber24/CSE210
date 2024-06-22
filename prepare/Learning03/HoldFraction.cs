using System;
using System.Dynamic;

public class Fraction
{
    private int topNumber;
    private int bottomNumber;

    public Fraction()
    {
        topNumber = 1;
        bottomNumber = 1;
    }

    public Fraction(int wholeNumber) //Constructor
    {
        topNumber = wholeNumber;
        bottomNumber = 1;
    }
    public Fraction(int top, int bottom)
    {
        topNumber = top;
        bottomNumber = bottom;
    }
    public string GetFractionString()
    {
        string text = $"{topNumber}/{bottomNumber}";
        return text;
    }
    public double GetDecimalValue()
    {
        double roundedFraction = Math.Round((double)topNumber / (double)bottomNumber, 2);
        return roundedFraction;
    }
}