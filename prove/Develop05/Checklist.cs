using System;

public class Checklist : Goal
{
    private int _stepPoints;
    private int _count;
    private int _stepCount;

    public Checklist(int pVal, int stepPval, string name, int stepCount) : base(pVal, name) {
        _pointValue = pVal;
        _stepPoints = stepPval;
        _goalName = name;
        _stepCount = stepCount;
        _ending = true;
        _complete = false;
    }

    public override void DisplayGoal() {
        string check = $"{_count}/{_stepCount}";
        if (_complete) {
            check = "X";
        }
        Console.WriteLine($"[{check}] {_goalName}");
        Console.WriteLine($"Points earned upon completion: {_pointValue}");
        Console.WriteLine($"Points for each time complete: {_stepPoints}");
    }

    public override int MarkComplete() {
        _count += 1;
        if (_count == _stepCount) {
            _complete = true;
            return _pointValue;
        } else {
            return _stepPoints;
        }
    }

    public void SetVars(bool a, bool b, int c) {
        _ending = a;
        _complete = b;
        _count = c;
    }

    public override bool GetStatus() {
        return _complete;
    }

    public override string Stringify() {
        return $"c | {_pointValue} | {_goalName} | {_ending} | {_complete} | {_stepPoints} | {_count} | {_stepCount}";
    }
}