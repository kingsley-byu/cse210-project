using System;

class Program
{
    static void Main(string[] args)
    {
        Fractions p1 = new Fractions();
        Console.WriteLine(p1.GetFractionString());
        Console.WriteLine(p1.GetDecimalValue());

        Fractions p2 = new Fractions(5);
        Console.WriteLine(p2.GetFractionString());
        Console.WriteLine(p2.GetDecimalValue());

        Fractions p3 = new Fractions(3,4);
        Console.WriteLine(p3.GetFractionString());
        Console.WriteLine(p3.GetDecimalValue());

        Fractions p4 = new Fractions(1,3);
        Console.WriteLine(p4.GetFractionString());
        Console.WriteLine(p4.GetDecimalValue());
    }
    
}