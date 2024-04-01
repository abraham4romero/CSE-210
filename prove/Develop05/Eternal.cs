using System;

public class Eternal : Goal
{
    private int _stepPoints;
    private int _count = 0;

    public Eternal(int pVal, int stepPval, string name) : base(pVal, name) {
        _pointValue = pVal;
        _stepPoints = stepPval;
        _goalName = name;
        _ending = false;
        _complete = false;
    }

    public override void DisplayGoal() {
        Console.WriteLine($"[{_count}] {_goalName}");
        Console.WriteLine($"Points for each time complete: {_stepPoints}");
    }

    public override int MarkComplete() {
        _count += 1;
        return _stepPoints;
    }

    public void SetVars(bool a, bool b, int c) {
        _ending = a;
        _complete = b;
        _count = c;
    }

    public override string GetStatus() {
        throw new NotImplementedException();
    }

    public override void Destringify() {

    }

    public override string Stringify() {
        return $"e | {_pointValue} | {_goalName} | {_ending} | {_complete} | {_stepPoints} | {_count}";
    }
}