using System;

class Program
{
    static void Main(string[] args)
    {
        
        Fraction first = new Fraction();
        Console.WriteLine(first.GetFractionString());
        Console.WriteLine(first.GetDecimal());
        Fraction second = new Fraction(6);
        Console.WriteLine(second.GetFractionString());
        Console.WriteLine(second.GetDecimal());        

        Fraction third = new Fraction(6, 7);
        Console.WriteLine(third.GetFractionString());
        Console.WriteLine(third.GetDecimal());

    }
}