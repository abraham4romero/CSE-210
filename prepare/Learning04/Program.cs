using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment MA1 = new MathAssignment("Perry Platypus", "Integrals", "8.9", "5-14");
        Console.WriteLine(MA1.GetSummary());
        Console.WriteLine(MA1.GetHomeworkList());

        WritingAssignment WA1 = new WritingAssignment("Molly Jones", "Documentary", "Whales of the Deep");
        Console.WriteLine(WA1.GetSummary());
        Console.WriteLine(WA1.GetWritingInformation());
    }
}