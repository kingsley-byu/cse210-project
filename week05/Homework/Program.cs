using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("kingsley", "Algebraic Fraction");
        assignment1.GetSummary();

        Console.WriteLine(assignment1.GetSummary());

        MathsAssignment assignment2 = new MathsAssignment("Roberto Rodriguez","Fraction", "7.3", "8-19");

        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeWorkList());

        WritingAssignment assignment3 = new WritingAssignment("mary waters", "European history", "The causes of world war 2 ");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
        

    }
}