using System;

class Program
{
    static void Main(string[] args)
    {
        // Test Fraction class

        // Test default constructor (1/1)
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        // Test whole number constructor (e.g., 5 -> 5/1)
        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        // Test numerator and denominator constructor (e.g., 3/4)
        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        // Test fraction with numerator = 1 and denominator = 3
        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());

        // Modify fraction values using setters
        fraction4.SetTop(7);
        fraction4.SetBottom(9);
        Console.WriteLine(fraction4.GetFractionString()); // 7/9
        Console.WriteLine(fraction4.GetDecimalValue());  // 0.777...
    }
}