using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction firstFraction = new Fraction();
        string fractionString = firstFraction.GetFractionString();
        Console.WriteLine(fractionString);
        double decimalValue = firstFraction.GetDecimalValue();
        Console.WriteLine(decimalValue);

        Fraction secondFraction = new Fraction(5);
        string secondFractionString = secondFraction.GetFractionString();
        Console.WriteLine(secondFractionString);
        double secondDecimalValue = secondFraction.GetDecimalValue();
        Console.WriteLine(secondDecimalValue);

        Fraction thirdFraction = new Fraction(3, 4);
        string thirdFractionString = thirdFraction.GetFractionString();
        Console.WriteLine(thirdFractionString);
        double thirdDecimalValue = thirdFraction.GetDecimalValue();
        Console.WriteLine(thirdDecimalValue);

        Fraction fourthFraction = new Fraction(1, 3);
        string fourthFractionString = fourthFraction.GetFractionString();
        Console.WriteLine(fourthFractionString);
        double fourthDecimalValue = fourthFraction.GetDecimalValue();
        Console.WriteLine(fourthDecimalValue);


    }
}