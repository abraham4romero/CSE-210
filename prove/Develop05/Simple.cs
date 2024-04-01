using System;

public class Simple : Goal
{
    public Simple(int pVal, string name) : base(pVal, name) {
        _pointValue = pVal;
        _goalName = name;
        _ending = true;
        _complete = false;
    }

    public override void DisplayGoal() {
        string check = "";
        if (_complete) {
            check = "X";
        }
        Console.WriteLine($"[{check}] {_goalName}");
        Console.WriteLine($"Points earned upon completion: {_pointValue}");
    }

    public override int MarkComplete() {
        _complete = true;
        return _pointValue;
    }

    public void SetVars(bool a, bool b) {
        _ending = a;
        _complete = b;
    }

    public override string GetStatus() {
        throw new NotImplementedException();
    }

    public override void Destringify() {

    }

    public override string Stringify() {
        return $"s | {_pointValue} | {_goalName} | {_ending} | {_complete}";  
    }
}