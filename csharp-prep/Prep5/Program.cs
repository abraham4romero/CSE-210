using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {  
        DisplayWelcome();
        string name = GetName();
        int num = GetNum();

        int numsqr = SquareNum(num);

        DisplayResults(name, numsqr);

    }

    static void DisplayWelcome() {
        Console.WriteLine("Welcome to the Program!");
    }

    static string GetName() {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int GetNum() {
        Console.WriteLine("Please enter your favorite number: ");
        int num = int.Parse(Console.ReadLine());

        return num;
    }

    static int SquareNum(int num) {
        int numsqr = num * num;

        return numsqr;
    }
    static void DisplayResults(string name, int numsqr) {
        Console.WriteLine($"{name}, the square of your number is {numsqr}");
    }
}