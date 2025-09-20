using System;
public class HoldFractions
{
    private int _numerator;
    private int _denominator;

    public HoldFractions(int wholeNumber)
    {
        _numerator = wholeNumber;
        _denominator = 1;
    }

    public HoldFractions(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }
    public string GetFractionString()
    {
        string text = $"{_numerator}/{_denominator}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}
