using System;

public class Fraction
{
    // Private attributes for encapsulation
    private int _top;
    private int _bottom;

    // Default constructor initializes to 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor to initialize to whole number (e.g., 5 becomes 5/1)
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Constructor to initialize with numerator and denominator
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom != 0 ? bottom : throw new ArgumentException("Denominator cannot be zero.");
    }

    // Getter for numerator (top)
    public int GetTop()
    {
        return _top;
    }

    // Setter for numerator (top)
    public void SetTop(int top)
    {
        _top = top;
    }

    // Getter for denominator (bottom)
    public int GetBottom()
    {
        return _bottom;
    }

    // Setter for denominator (bottom)
    public void SetBottom(int bottom)
    {
        if (bottom == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        _bottom = bottom;
    }

    // Method to return fraction as a string (e.g., "3/4")
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Method to return decimal value of the fraction (e.g., 0.75)
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}
