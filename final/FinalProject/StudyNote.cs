using System;

public class StudyNote : Note
{
    private string _title;

    public StudyNote(string ti, string t) : base(t) {
        _title = ti;
    }

    public override void Print() {
        
    }
}