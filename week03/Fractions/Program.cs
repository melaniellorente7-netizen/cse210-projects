using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction number1 = new Fraction();
        Console.WriteLine(number1.GetFractionString());
        Console.WriteLine(number1.GetDecimalValue());

        Fraction number2 = new Fraction(5);
        Console.WriteLine(number2.GetFractionString());
        Console.WriteLine(number2.GetDecimalValue());

        Fraction number3 = new Fraction(3, 4);
        Console.WriteLine(number3.GetFractionString());
        Console.WriteLine(number3.GetDecimalValue());

        Fraction number4 = new Fraction(1, 3);
        Console.WriteLine(number4.GetFractionString());
        Console.WriteLine(number4.GetDecimalValue());
    
    }
}