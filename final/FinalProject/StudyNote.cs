using System;
using System.ComponentModel.DataAnnotations;

public class StudyNote : Note
{
    private string _title;

    public StudyNote(string ti, string t) : base(t) {
        _title = ti;
    }

    public string Name() {
        return _title;
    }

    public override void Print() {
        Console.WriteLine(_title);
        Console.WriteLine(_text);
    }

    public void Edit() {
        Console.Clear();
        Console.WriteLine("Your note currently says:");
        Console.WriteLine(_text);
        Console.WriteLine("");
        Console.WriteLine("What would you like to replace it with?");
        _text = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Note updated.");
        Thread.Sleep(1000);
    }
}