using System;

public abstract class Note
{
    protected string _text;

    public Note(string t) {
        _text = t;
    }

    public abstract void Print();
}