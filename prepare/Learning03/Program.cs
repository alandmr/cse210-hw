using System;

class Program
{
    static void Main(string[] args)
    {        
        Fraction fraction = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3,4);
        Fraction fraction4 = new Fraction(1,3);

        // Display result for 1st instance of fraction
        Console.WriteLine(fraction.getFractionString());
        Console.WriteLine(fraction.getDecimalValue());

        // Display result for 2nd instance of fraction
        Console.WriteLine(fraction2.getFractionString());
        Console.WriteLine(fraction2.getDecimalValue());

        // Display result for 3nd instance of fraction
        Console.WriteLine(fraction3.getFractionString());
        Console.WriteLine(fraction3.getDecimalValue());

        // Display result for 4th instance of fraction
        Console.WriteLine(fraction4.getFractionString());
        Console.WriteLine(fraction4.getDecimalValue());               
        
    }
}