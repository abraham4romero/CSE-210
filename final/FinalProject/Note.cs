using System;

public abstract class Note
{
    protected string _text;

    public Note(string t) {
        _text = t;
    }

    public void SetText(string t) {
        _text = t;
    }

    public string Text() {
        return _text;
    }

    public abstract void Print();
}