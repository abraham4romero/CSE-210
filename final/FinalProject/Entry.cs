using System;

public class Entry : Note
{
    private DateTime _day;
    private int _number;
    private string _weather;

    public Entry(DateTime d, int n, string w, string t) : base(t) {
        _day = d;
        _number = n;
        _weather = w;
    }

    public override void Print() {
        Console.WriteLine($"{_day.Month}-{_day.Day}-{_day.Year} #{_number}");
        Console.WriteLine($"Weather: {_weather}");
        Console.WriteLine(_text);
    }
}