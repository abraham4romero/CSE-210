using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name?");
        string ARfirst = Console.ReadLine();
        Console.WriteLine("What is your last name?");
        string ARlast = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine($"Your name is {ARlast}, {ARfirst} {ARlast}");
    }
}