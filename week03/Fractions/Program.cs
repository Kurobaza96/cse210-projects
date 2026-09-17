using System;

class Program
{
    static void Main(string[] args)
    {
        // Test the default constructor: 1/1
        Fraction fraction1 = new Fraction();

        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        // Test the one-parameter constructor: 5/1
        Fraction fraction2 = new Fraction(5);

        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        // Test the two-parameter constructor: 3/4
        Fraction fraction3 = new Fraction(3, 4);

        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        // Test another fraction: 1/3
        Fraction fraction4 = new Fraction(1, 3);

        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());

        // Test getters
        Console.WriteLine($"Top: {fraction3.GetTop()}");
        Console.WriteLine($"Bottom: {fraction3.GetBottom()}");

        // Test setters
        fraction3.SetTop(5);
        fraction3.SetBottom(8);

        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());
    }
}