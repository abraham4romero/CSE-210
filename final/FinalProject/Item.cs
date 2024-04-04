using System;

public class Item : Note
{
    private bool _complete;
    private bool _due = false;
    private DateTime _dueDate;

    public Item(bool c, bool due, string t, DateTime d) : base(t) {
        _complete = c;
        _due = due;
        _dueDate = d;
    }

    public Item(bool c, string t) : base(t) {
        _complete = c;
    }

    public void Complete() {
        _complete = true;
    }

    public override void Print() {
        if ((_complete == true) && (_due == true)) {
            Console.WriteLine($"[X] {_text}");
            Console.WriteLine($"    Due on: {_dueDate.Month}-{_dueDate.Day}-{_dueDate.Year} @ {_dueDate.Hour}:{_dueDate.Minute}");
        } else if ((_complete == true) && (_due == false)) {
            Console.WriteLine($"[X] {_text}");
        } else if ((_complete == false) && (_due == true)) {
            Console.WriteLine($"[ ] {_text}");
            Console.WriteLine($"    Due on: {_dueDate.Month}-{_dueDate.Day}-{_dueDate.Year} @ {_dueDate.Hour}:{_dueDate.Minute}");
        } else {
            Console.WriteLine($"[ ] {_text}");
        }
    }
}