using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your current grade as a percentage?");
        string ARinput = Console.ReadLine();
        int ARpercentage = int.Parse(ARinput);
        string ARgrade;
        if (ARpercentage >= 90) {
            ARgrade = "A";
        } else if (ARpercentage >= 80) {
            ARgrade = "B";
        } else if (ARpercentage >= 70) {
            ARgrade = "C";
        } else if (ARpercentage >= 60) {
            ARgrade = "D";
        } else {
            ARgrade = "F";
        }

        Console.WriteLine($"With {ARinput} percent, your grade is {ARgrade}.");
    }
}