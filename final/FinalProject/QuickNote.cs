using System;

public class QuickNote : Note
{
    public QuickNote(string t) : base(t) {
        
    }

    public override void Print() {
        Console.WriteLine(_text);
    }
}